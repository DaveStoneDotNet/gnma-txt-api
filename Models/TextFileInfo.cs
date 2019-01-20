using System;
using System.Diagnostics;

namespace Cooper.Gnma.Text.Models
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class TextFileInfo
    {
        public string Name { get; set; }                   // The Name of the File, including the extension. The file name without the extension can be obtained by calling 'System.IO.Path.GetFileNameWithoutExtension(importFileInfo.Name)'
        public string Extension { get; set; }              // The Extension of the File, including the leading PERIOD '.' character. e.g. '.xlsx' instead of 'xlsx'.
        public string Size { get; set; }

        public bool Exists { get; set; }

        public string DirectoryName { get; set; }
        public string FullName { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }

        public long Length { get; set; }

        // ---

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{this.Name}";
    }
}
