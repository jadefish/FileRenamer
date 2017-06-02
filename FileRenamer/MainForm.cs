using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamer
{
	public partial class MainForm : Form
	{
		private const uint MAX_FILE_NAME_LENGTH = 255;
		private static readonly string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private static readonly string NUMBERS = "0123456789";
		private static readonly string SYMBOLS = "~!@#$%^&*()_+`-=[]{};',.";
		private Random random = new Random();

		private enum NamingModes
		{
			Numerical = 0,
			Random = 1
		}

		private enum SortOrders
		{
			Ascending = 0,
			Descending = 1,
			Random = 2
		}

		private DirectoryInfo selectedDirectory;
		private FileInfo[] files;
		private int checkedCount = 0;
		private NamingModes namingMode = NamingModes.Random;
		private SortOrders sortOrder = SortOrders.Ascending;

		public MainForm()
		{
			InitializeComponent();

			this.Font = SystemFonts.MessageBoxFont;
			statusStrip_progress.Renderer = new FlatStatusStripRenderer();
			comboBox_sortBy.SelectedIndex = 0;
		}

		private void radioButton_numerical_CheckedChanged(object sender, EventArgs e)
		{
			groupBox_numericOptions.Enabled = radioButton_numerical.Checked;
			groupBox_randomOptions.Enabled = radioButton_random.Checked;

			namingMode = NamingModes.Numerical;
		}

		private void radioButton_random_CheckedChanged(object sender, EventArgs e)
		{
			groupBox_numericOptions.Enabled = radioButton_numerical.Checked;
			groupBox_randomOptions.Enabled = radioButton_random.Checked;

			namingMode = NamingModes.Random;
		}

		private void button_selectDirectory_Click(object sender, EventArgs e)
		{
			button_selectDirectory.Enabled = false;
		}

		private void button_reset_Click(object sender, EventArgs e)
		{
			resetFields();
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private async void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] dragItems = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (dragItems.Length > 0)
			{
				// Accept only the first item:
				string directory = dragItems[0];

				if (!loadDirectory(directory))
				{
					resetFields();
					return;
				}

				if (!loadFiles(selectedDirectory))
				{
					resetFields();
					return;
				}

				toolStripStatusLabel_status.Text = string.Format("Loading files...", files.Length);
				toolStripProgressBar.Maximum = files.Length;
				toolStripProgressBar.Visible = true;

				await Task.Run(() => { populateFileListBox(); });

				toolStripProgressBar.Visible = false;
				button_processFiles.Enabled = true;
				toolStripStatusLabel_status.Text = string.Format("Loaded {0} files. Click 'Process files' to start.", files.Length);
			}
		}

		private void resetFields()
		{
			selectedDirectory = null;
			textBox_directoryPath.Text = string.Empty;
			files = null;
			checkedListBox_files.Items.Clear();
			button_processFiles.Enabled = false;
			button_reset.Enabled = false;
			panel_renamingOptions.Enabled = false;
			splitContainer.Enabled = false;
			toolStripProgressBar.Visible = false;
			toolStripProgressBar.Value = 0;
			toolStripProgressBar.Maximum = 0;
			toolStripStatusLabel_status.Text = "Select a directory to get started.";
		}

		private bool loadDirectory(string directory)
		{
			DirectoryInfo directoryInfo;

			try
			{
				directoryInfo = new DirectoryInfo(directory);

				if (!directoryInfo.Exists || !UserHasAccess(directoryInfo))
				{
					return false;
				}
			}
			catch (ArgumentNullException)
			{
				MessageBox.Show("Unable to locate directory \"" + directory + "\".");
				return false;
			}
			catch (SecurityException)
			{
				MessageBox.Show("Unable to access directory \"" + directory + "\".");
				return false;
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Directory \"" + directory + "\" contains one or more invalid characters.");
				return false;
			}
			catch (PathTooLongException)
			{
				MessageBox.Show("The provided path is too long.");
				return false;
			}

			selectedDirectory = directoryInfo;
			textBox_directoryPath.Text = selectedDirectory.ToString();
			button_reset.Enabled = true;
			panel_renamingOptions.Enabled = true;
			splitContainer.Enabled = true;

			return true;
		}

		private bool UserHasAccess(DirectoryInfo directoryInfo)
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			FileIOPermission readPermission = new FileIOPermission(FileIOPermissionAccess.Read, directoryInfo.FullName);
			FileIOPermission writePermission = new FileIOPermission(FileIOPermissionAccess.Write, directoryInfo.FullName);
			permissionSet.AddPermission(readPermission);
			permissionSet.AddPermission(writePermission);

			return permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet);
		}

		private bool loadFiles(DirectoryInfo directoryInfo)
		{
			try
			{
				List<FileInfo> fileList = new List<FileInfo>(directoryInfo.GetFiles());
				fileList.Sort(new FileInfoNaturalNameComparer(true));
				files = fileList.ToArray();
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("Unable to locate directory \"" + directoryInfo.FullName + "\".");
				return false;
			}

			if (files.Length <= 0)
			{
				MessageBox.Show("Please select a directory containing at least 1 file.");
				return false;
			}

			return true;
		}

		private void populateFileListBox()
		{
			for (int i = 0; i < files.Length; i++)
			{
				checkedListBox_files.Invoke(new Action(() =>
				{
					checkedListBox_files.Items.Add(files[i].Name, true);
					checkedCount = checkedListBox_files.CheckedItems.Count;
				}));

				statusStrip_progress.Invoke(new Action(() =>
				{
					toolStripProgressBar.Value = i + 1;
				}));

				label_checkedCount.Invoke(new Action(() =>
				{
					label_checkedCount.Text = string.Format("{0}/{1}", checkedCount, checkedListBox_files.Items.Count);
				}));

				// System.Threading.Thread.Sleep(2);
			}
		}

		private void checkedListBox_files_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			checkedCount += (e.NewValue == CheckState.Checked ? 1 : -1) * 1;
			string count = string.Format("{0}/{1}", checkedCount, checkedListBox_files.Items.Count);
			label_checkedCount.Text = count;
		}

		private void button_processFiles_Click(object sender, EventArgs e)
		{
			if (namingMode == NamingModes.Numerical)
			{
				List<FileInfo> fileList = new List<FileInfo>(files);

				// Sort files according to user preferences:
				switch (comboBox_sortBy.SelectedIndex)
				{
					case 0:		// Name
					default:
						fileList.Sort(new FileInfoNaturalNameComparer(sortOrder == SortOrders.Ascending));
						break;
					case 1:		// Size
						fileList.Sort(new FileInfoSizeComparer(sortOrder == SortOrders.Ascending));
						break;
					case 2:		// Date created
						fileList.Sort(new FileInfoDateCreatedComparer(sortOrder == SortOrders.Ascending));
						break;
					case 3:		// Date modified
						fileList.Sort(new FileInfoDateModifiedComparer(sortOrder == SortOrders.Ascending));
						break;
				}

				files = fileList.ToArray();

				// Create new file names:
				string[] newFileNames = new string[files.Length];
				int padding = 0;

				if (checkBox_padWithLeadingZeroes.Checked)
				{
					padding = (int)Math.Log10(files.Length) + 1;
				}

				for (int i = 0; i < newFileNames.Length; i++)
				{
					string extension = files[i].Extension;
					string path = Path.GetDirectoryName(files[i].FullName);
					newFileNames[i] = string.Format("{0}{1}", Path.Combine(path, (i + 1).ToString("D" + padding)), extension);
					File.Move(files[i].FullName, newFileNames[i]);
					textBox_log.AppendText(string.Format("{0} -> {1}\n", files[i].Name, newFileNames[i]));
				}
			}
			else
			{
				// Create new file names:
				string[] newFileNames = new string[files.Length];

				for (int i = 0; i < newFileNames.Length; i++)
				{
					string extension = files[i].Extension;
					string path = Path.GetDirectoryName(files[i].FullName);
					string newName = GetRandomString(5, 15);
					newFileNames[i] = string.Format("{0}{1}", Path.Combine(path, newName), extension);
					File.Move(files[i].FullName, newFileNames[i]);
					textBox_log.AppendText(string.Format("{0} -> {1}\n", files[i].Name, newFileNames[i]));
				}
			}

			button_processFiles.Enabled = false;
		}

		private string GetRandomString(uint minLength, uint maxLength)
		{
			StringBuilder builder = new StringBuilder();
			string validCharacters = "";

			if (checkBox_allowLetters.Checked)
			{
				if (checkBox_allowUppercase.Checked)
				{
					builder.Append(LETTERS);
				}

				if (checkBox_allowLowercase.Checked)
				{
					builder.Append(LETTERS.ToLower());
				}
			}

			if (checkBox_allowNumbers.Checked)
			{
				builder.Append(NUMBERS);
			}

			if (checkBox_allowSymbols.Checked)
			{
				builder.Append(SYMBOLS);
			}

			if (checkBox_allowSpaces.Checked)
			{
				builder.Append(' ');
			}

			validCharacters = builder.ToString();

			return new string(
				Enumerable.Repeat(validCharacters, random.Next((int)minLength, (int)maxLength))
						  .Select(s => s[random.Next(s.Length)])
						  .ToArray());
		}

		private void radioButton_sortOrders_CheckChanged(object sender, EventArgs e)
		{
			Control senderControl = sender as Control;

			if (senderControl.Tag == null)
			{
				sortOrder = SortOrders.Ascending;
			}
			else
			{
				sortOrder = (SortOrders)(int.Parse(senderControl.Tag.ToString()));
			}
		}
	}
}
