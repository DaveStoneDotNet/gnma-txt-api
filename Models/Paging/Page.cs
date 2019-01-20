
using System.Collections.Generic;
using System.Diagnostics;

namespace Cooper.Gnma.Text.Models.Paging
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class Page<TItem>
    {
        public int TotalRecordCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageNumber { get; set; }
        public int RecordsPerPage { get; set; }

        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }

        public List<TItem> Items { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"Page { PageNumber } of { TotalPageCount }";
    }
}
