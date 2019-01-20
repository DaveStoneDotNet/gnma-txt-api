using System;
using System.Collections.Generic;

namespace Cooper.Gnma.Text.Models.Responses
{
    public class FileShareLocationResponse
    {
        public string Path { get; set; }

        public List<String> Messages { get; set; }
    }
}
