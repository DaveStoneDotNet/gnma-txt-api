using System.Collections;
using System.Diagnostics;

namespace Cooper.Gnma.Text.Models
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class PoolRecordLayout
    {
        // These are all the things that should NEVER CHANGE or ever be updated

        public string RecordType        { get; set; }      // P01, P02, M01, M02, S01, S02, N01, N02, B01, B02, etc.
        public string RecordLevel       { get; set; }      // Pool or Loan
        public string FieldName         { get; set; }      // Record Type, Filler, Pool Number, Issue Type, etc.
        public string PropertyName      { get; set; }      // Corresponding C# Property Name version of the FieldName
        public string Type              { get; set; }      // Alpha, Numeric, AlphaNumeric, Space, Date, etc.
        public string Format            { get; set; }      // 'P01', '999999 or XX9999', 'X, C or M', '9999', etc.
        public string Source            { get; set; }      // Where the value originated from. e.g. [PoolTradeManagement].[PoolData].[PGNumber], calculated in [SomeView], hard-coded, etc.
        public string Description       { get; set; }      // Any additional notes or descriptions
        public string Align             { get; set; }      // Left or Right

        public char   Pad               { get; set; }      // Typically a '0' or SPACE character. The character to use when the length of the value is less than the total allowed Length.

        public int Index                { get; set; }      // Sort Order / Line Number
        public int Length               { get; set; }      // Number of characters
        public int Start                { get; set; }      // Starting Character Position on a Line
        public int End                  { get; set; }      // Ending Character Position on a Line (Start + Length)
        public int DecimalPlaces        { get; set; }      // 2, 3, etc.

        public bool IsRequired          { get; set; }

        public ArrayList Constraints    { get; set; }       // For example, parsed value must be 'X, C or M'

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{this.RecordType} - {this.PropertyName}";
    }
}
