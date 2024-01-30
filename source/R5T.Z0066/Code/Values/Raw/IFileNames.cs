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
    public partial interface IFileNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>File01.txt</value></para>
        /// </summary>
        public string N001 => "File01.txt";

        /// <summary>
        /// <para><value>File02.txt</value></para>
        /// </summary>
        public string N002 => "File02.txt";

        /// <summary>
        /// <para><value>File03.txt</value></para>
        /// </summary>
        public string N003 => "File03.txt";

        /// <summary>
        /// <para><value>File04.txt</value></para>
        /// </summary>
        public string N004 => "File04.txt";

        /// <summary>
        /// <para><value>File05.txt</value></para>
        /// </summary>
        public string N005 => "File05.txt";

        /// <summary>
        /// <para><value>File06.txt</value></para>
        /// </summary>
        public string N006 => "File06.txt";

        /// <summary>
        /// <para><value>File01</value></para>
        /// </summary>
        public string N007 => "File01";

        /// <summary>
        /// <para><value>First.Second.txt</value></para>
        /// </summary>
        public string N008 => "First.Second.txt";
    }
}
