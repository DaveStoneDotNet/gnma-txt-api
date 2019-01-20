using System;
using System.Collections.Generic;

namespace Cooper.Gnma.Text.Models.Responses
{
    public class FileInfoResponse
    {
        public List<TextFileInfo> FileInfos { get; set; }

        public List<String> Messages { get; set; }
    }
}
