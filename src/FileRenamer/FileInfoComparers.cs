using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace FileRenamer
{
	[SuppressUnmanagedCodeSecurity]
	internal static class SafeNativeMethods
	{
		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
		public static extern int StrCmpLogicalW(string psz1, string psz2);
	}

	public sealed class FileInfoNaturalNameComparer : IComparer<FileInfo>
	{
		private bool ascending = true;

		public FileInfoNaturalNameComparer(bool ascending)
		{
			this.ascending = ascending;
		}

		public int Compare(FileInfo a, FileInfo b)
		{
			return this.ascending ? SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name) : SafeNativeMethods.StrCmpLogicalW(b.Name, a.Name);
		}
	}

	public sealed class FileInfoSizeComparer : IComparer<FileInfo>
	{
		private bool ascending = true;

		public FileInfoSizeComparer(bool ascending)
		{
			this.ascending = ascending;
		}

		public int Compare(FileInfo a, FileInfo b)
		{
			return this.ascending ? a.Length.CompareTo(b.Length) : b.Length.CompareTo(a.Length);
		}
	}

	public sealed class FileInfoDateCreatedComparer : IComparer<FileInfo>
	{
		private bool ascending = true;

		public FileInfoDateCreatedComparer(bool ascending)
		{
			this.ascending = ascending;
		}

		public int Compare(FileInfo a, FileInfo b)
		{
			return this.ascending ? a.CreationTime.CompareTo(b.CreationTime) : b.CreationTime.CompareTo(a.CreationTime);
		}
	}

	public sealed class FileInfoDateModifiedComparer : IComparer<FileInfo>
	{
		private bool ascending = true;

		public FileInfoDateModifiedComparer(bool ascending)
		{
			this.ascending = ascending;
		}

		public int Compare(FileInfo a, FileInfo b)
		{
			return this.ascending ? a.LastWriteTime.CompareTo(b.LastWriteTime) : b.LastWriteTime.CompareTo(b.LastWriteTime);
		}
	}
}
