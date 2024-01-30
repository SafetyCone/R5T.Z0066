using System;


namespace R5T.Z0066
{
    public class DateTimes : IDateTimes
    {
        #region Infrastructure

        public static IDateTimes Instance { get; } = new DateTimes();


        private DateTimes()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class DateTimes : IDateTimes
    {
        #region Infrastructure

        public static IDateTimes Instance { get; } = new DateTimes();


        private DateTimes()
        {
        }

        #endregion
    }
}
