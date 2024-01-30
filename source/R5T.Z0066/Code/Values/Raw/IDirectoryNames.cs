using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Prior work:
    /// * R5T.Salamis
    /// * R5T.T0021.X0002
    /// </remarks>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>Directory01</value></para>
        /// </summary>
        public string N001 => "Directory01";

        /// <summary>
        /// <para><value>Directory02</value></para>
        /// </summary>
        public string N002 => "Directory02";

        /// <summary>
        /// <para><value>Directory03</value></para>
        /// </summary>
        public string N003 => "Directory03";

        /// <summary>
        /// <para><value>Directory04</value></para>
        /// </summary>
        public string N004 => "Directory04";

        /// <summary>
        /// <para><value>Directory..Name</value></para>
        /// </summary>
        public string N005 => "Directory..Name";

        /// <summary>
        /// <para><value>"." (the current directory path)</value></para>
        /// </summary>
        public string N006 => @".";

        /// <summary>
        /// <para><value>".." (the parent directory path)</value></para>
        /// </summary>
        public string N007 => @"..";
    }
}
