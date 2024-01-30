using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IRootPaths : IValuesMarker
    {
        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N00 => @"";

        /// <summary>
        /// <para><value>C:</value></para>
        /// </summary>
        public string N001 => @"C:";

        /// <summary>
        /// <para><value>mnt</value></para>
        /// </summary>
        public string N002 => @"mnt";

        /// <summary>
        /// <para><value>MKX</value></para>
        /// </summary>
        public string N003 => @"MKX";
    }
}
