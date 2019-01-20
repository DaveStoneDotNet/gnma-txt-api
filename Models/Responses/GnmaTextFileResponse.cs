using System;
using System.Collections.Generic;

namespace Cooper.Gnma.Text.Models.Responses
{
    public class GnmaTextFileResponse
    {
        public string FileName { get; set; }

        public List<String> Lines { get; set; }
        public List<String> Messages { get; set; }

        public bool IsSuccessful { get; set; }
    }
}
