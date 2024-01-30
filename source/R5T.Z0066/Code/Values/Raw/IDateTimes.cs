using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IDateTimes : IValuesMarker
    {
        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N0 => "";

        /// <summary>
        /// <para><value>2023-03-31 15:18:17</value></para>
        /// </summary>
        public DateTime N001 => new DateTime(2023, 03, 31, 15, 18, 17);
    }
}
