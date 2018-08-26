﻿using System.Security.AccessControl;

namespace System.IO.Abstractions
{
    /// <inheritdoc cref="FileInfo"/>
    [Serializable]
    public abstract class FileInfoBase : FileSystemInfoBase
    {
        /// <inheritdoc cref="FileInfo.AppendText"/>
        public abstract StreamWriter AppendText();

        /// <inheritdoc cref="FileInfo.CopyTo(string)"/>
        public abstract FileInfoBase CopyTo(string destFileName);

        /// <inheritdoc cref="FileInfo.CopyTo(string,bool)"/>
        public abstract FileInfoBase CopyTo(string destFileName, bool overwrite);

        /// <inheritdoc cref="FileInfo.Create"/>
        public abstract Stream Create();

        /// <inheritdoc cref="FileInfo.CreateText"/>
        public abstract StreamWriter CreateText();

#if NET40
        /// <inheritdoc cref="FileInfo.Decrypt"/>
        public abstract void Decrypt();

        /// <inheritdoc cref="FileInfo.Encrypt"/>
        public abstract void Encrypt();
#endif

        /// <inheritdoc cref="FileInfo.GetAccessControl()"/>
        public abstract FileSecurity GetAccessControl();

        /// <inheritdoc cref="FileInfo.GetAccessControl(AccessControlSections)"/>
        public abstract FileSecurity GetAccessControl(AccessControlSections includeSections);

        /// <inheritdoc cref="FileInfo.MoveTo"/>
        public abstract void MoveTo(string destFileName);

        /// <inheritdoc cref="FileInfo.Open(FileMode)"/>
        public abstract Stream Open(FileMode mode);

        /// <inheritdoc cref="FileInfo.Open(FileMode,FileAccess)"/>
        public abstract Stream Open(FileMode mode, FileAccess access);

        /// <inheritdoc cref="FileInfo.Open(FileMode,FileAccess,FileShare)"/>
        public abstract Stream Open(FileMode mode, FileAccess access, FileShare share);

        /// <inheritdoc cref="FileInfo.OpenRead"/>
        public abstract Stream OpenRead();

        /// <inheritdoc cref="FileInfo.OpenText"/>
        public abstract StreamReader OpenText();

        /// <inheritdoc cref="FileInfo.OpenWrite"/>
        public abstract Stream OpenWrite();

#if NET40
        /// <inheritdoc cref="FileInfo.Replace(string,string)"/>
        public abstract FileInfoBase Replace(string destinationFileName, string destinationBackupFileName);

        /// <inheritdoc cref="FileInfo.Replace(string,string,bool)"/>
        public abstract FileInfoBase Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
#endif

        /// <inheritdoc cref="FileInfo.SetAccessControl(FileSecurity)"/>
        public abstract void SetAccessControl(FileSecurity fileSecurity);

        /// <inheritdoc cref="FileInfo.Directory"/>
        public abstract DirectoryInfoBase Directory { get; }

        /// <inheritdoc cref="FileInfo.DirectoryName"/>
        public abstract string DirectoryName { get; }

        /// <inheritdoc cref="FileInfo.IsReadOnly"/>
        public abstract bool IsReadOnly { get; set; }

        /// <inheritdoc cref="FileInfo.Length"/>
        public abstract long Length { get; }

        public static implicit operator FileInfoBase(FileInfo fileInfo)
        {
            if (fileInfo == null)
            {
                return null;
            }
            
            return new FileInfoWrapper(fileInfo);
        }
    }
}
