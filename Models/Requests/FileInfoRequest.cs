
using System;

namespace Cooper.Gnma.Text.Models.Requests
{
    public class FileInfoRequest : RequestBase
    {
        public string Path { get; set; }
        public string SearchPattern { get; set; }
        public string FullPathAndFileName { get; set; }
    }
}
