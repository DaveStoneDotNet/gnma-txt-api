
namespace Cooper.Gnma.Text.Models
{
    public static class Constants
    {
        #region LevelAbbreviations
        /// <summary>
        /// Intended to provide a definition of the first letter of every possible 'Level' in a GNMA Text File. e.g. P, M, S, etc.
        /// </summary>
        /// <remarks>
        /// Single-family Pools consist of the several Levels of Information, e.g. Pool Level Information, Mortgage Level Information, etc. 
        /// Each Level is represented by a group of Physical Records (i.e. actual records) which is called a Logical Record with a 'RecordType'.
        /// e.g. P01, P02, etc. Each 'RecordType' will then contain a collection of Fields with assigned Types, Lengths, and Positions defined 
        /// in a PoolRecordLayout.
        /// </remarks>
        public static class LevelAbbreviations
        {
            public const string P = "Pool";
            public const string M = "Mortgage";
            public const string S = "Subscriber";
            public const string N = "Serial Notes";
            public const string A = "Master Agreement";
            public const string B = "Builder Bond";
            public const string F = "Terminated Pool";
        }
        #endregion LevelAbbreviations

        #region Levels
        /// <summary>
        /// Intended to indicate every possible 'Level' in a GNMA Text File. e.g. Pool, Mortgage, Subscriber, etc.
        /// </summary>
        /// <remarks>
        /// Single-family Pools consist of the several Levels of Information, e.g. Pool Level Information, Mortgage Level Information, etc. 
        /// Each Level is represented by a group of Physical Records (i.e. actual records) which is called a Logical Record with a 'RecordType'.
        /// e.g. P01, P02, etc. Each 'RecordType' will then contain a collection of Fields with assigned Types, Lengths, and Positions defined 
        /// in a PoolRecordLayout.
        /// </remarks>
        public static class Levels
        {
            public const string Pool            = "Pool";
            public const string Mortgage        = "Mortgage";
            public const string Subscriber      = "Subscriber";
            public const string SerialNotes     = "Serial Notes";
            public const string MasterAgreement = "Master Agreement";
            public const string BuilderBond     = "Builder Bond";
            public const string TerminatedPool  = "Terminated Pool";
        }
        #endregion Levels

        #region RecordTypes
        /// <summary>
        /// Intended to indicate every possible 'RecordType' in a GNMA Text File. e.g. P01, P02, P03, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// Single-family Pools consist of the several Levels of Information, e.g. Pool Level Information, Mortgage Level Information, etc. 
        /// Each Level is represented by a group of Physical Records (i.e. actual records) which is called a Logical Record with a 'RecordType'.
        /// e.g. P01, P02, etc. Each 'RecordType' will then contain a collection of Fields with assigned Types, Lengths, and Positions defined 
        /// in a PoolRecordLayout.
        /// 
        /// These values are hard-coded into the constructer of every implemented 'IData'. For example, the 
        /// 'RecordType' of a P01_Data will always be 'P01'. The 'RecordType' of a P02_Data will always 
        /// be 'P02'. etc.
        /// 
        /// </remarks>
        public static class RecordTypes
        {
            public const string P01 = "P01";
            public const string P02 = "P02";
            public const string P03 = "P03";
            public const string P04 = "P04";
            public const string P05 = "P05";
            public const string P06 = "P06";
            public const string M01 = "M01";
            public const string M02 = "M02";
            public const string M03 = "M03";
            public const string M04 = "M04";
            public const string M05 = "M05";
            public const string M06 = "M06";
            public const string M07 = "M07";
            public const string M08 = "M08";
            public const string M10 = "M10";
            public const string M11 = "M11";
            public const string S01 = "S01";
            public const string S02 = "S02";
            public const string N01 = "N01";
            public const string N02 = "N02";
            public const string F01 = "F01";
            public const string F02 = "F02";
            public const string A01 = "A01";
            public const string B01 = "B01";
            public const string B02 = "B02";
        }
        #endregion RecordTypes

        #region RecordLevels
        /// <summary>
        /// Indicates the record 'level' such as Pool Level or Loan Level.
        /// </summary>
        public static class RecordLevels
        {
            public const string Pool         = "Pool";
            public const string Loan         = "Loan";
            public const string Subscriber   = "Loan";
            public const string Master       = "Master";
            public const string Serial       = "Serial";
            public const string Builder      = "Builder";
            public const string Terminal     = "Terminal";
            public const string Consolidated = "Consolidated";
            public const string Ignore       = "Ignore";
        }
        #endregion RecordLevels

        #region Alignments
        /// <summary>
        /// Essentially used in padding for a value to fit within a given length 
        /// with leading or trailing spaces or zeros.
        /// </summary>
        public static class Alignments
        {
            public const string Left  = "Left";
            public const string Right = "Right";
        }
        #endregion Alignments

        #region DataTypes
        /// <summary>
        /// All the possible Data Types that can be parsed out of a GNMA Text File. String, Int32, Decimal, DateTime or FILLER
        /// </summary>
        public static class DataTypes
        {
            public const string String   = "String";
            public const string Decimal  = "Decimal";
            public const string Int32    = "Int32";
            public const string DateTime = "DateTime";
            public const string FILLER   = "Filler";        // Filler that consists of at least one SPACE character.
        }
        #endregion DataTypes
    }
}
