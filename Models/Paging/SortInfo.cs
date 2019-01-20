using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace Cooper.Gnma.Text.Models.Paging
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class SortInfo
    {
        #region Properties

        #region PropertyName
        public string PropertyName
        {
            get;
            set;
        }
        #endregion PropertyName

        #region Order
        public SortOrder Order
        {
            get;
            set;
        }
        #endregion Order

        #region DebuggerDisplay
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{this.GetType().Name}({this.PropertyName} {this.Order})";

        #endregion DebuggerDisplay

        #endregion Properties

        #region Constructor

        #region SortInfo
        public SortInfo()
        {
        }
        #endregion SortInfo

        #endregion Constructor

        #region Create
        public static SortInfo Create<TSource, TResult>(Expression<Func<TSource, TResult>> propertySelector, SortOrder order)
        {
            if (propertySelector == null)
            {
                throw new ArgumentNullException(nameof(propertySelector));
            }

            var memberExpression = propertySelector.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new ArgumentException("Property selector expression must be a member expression", nameof(propertySelector));
            }

            var propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == null)
            {
                throw new ArgumentException("Property selector expression must return a property", nameof(propertySelector));
            }

            return new SortInfo
            {
                PropertyName = propertyInfo.Name,
                Order = order
            };
        }
        #endregion Create
    }
}
