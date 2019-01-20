using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Cooper.Gnma.Text.Models.Requests
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class SaveGnmaTextFileRequest
    {
        public string FileName { get; set; }
        public string FullPathAndFileName { get; set; }

        public List<String> Lines { get; set; }

        // ---

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{this.FileName}";
    }
}
