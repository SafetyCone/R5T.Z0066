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
    /// </remarks>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N00 => @"";

        /// <summary>
        /// <para><value>C:\Directory01\File01.txt</value></para>
        /// </summary>
        public string N001 => @"C:\Directory01\File01.txt";

        /// <summary>
        /// <para><value>C:\Directory01\File02.txt</value></para>
        /// </summary>
        public string N002 => @"C:\Directory01\File02.txt";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\File03.txt</value></para>
        /// </summary>
        public string N003 => @"C:\Directory01\Directory02\File03.txt";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03\File04.txt</value></para>
        /// </summary>
        public string N004 => @"C:\Directory01\Directory02\Directory03\File04.txt";

        /// <summary>
        /// <para><value>C:\Directory01\Directory04\File05.txt</value></para>
        /// </summary>
        public string N005 => @"C:\Directory01\Directory04\File05.txt";

        /// <summary>
        /// <para><value>C:\File06.txt</value></para>
        /// </summary>
        public string N006 => @"C:\File06.txt";

        /// <summary>
        /// <para><value>Directory01/File01.txt</value></para>
        /// </summary>
        public string N007 => @"Directory01/File01.txt";

        /// <summary>
        /// <para><value>C:\Directory01\File01.txt\</value></para>
        /// </summary>
        public string N008 => @"C:\Directory01\File01.txt\";

        /// <summary>
        /// <para><value>C:\Directory02\..\Directory01\File01.txt</value></para>
        /// </summary>
        public string N009 => @"C:\Directory02\..\Directory01\File01.txt";

        /// <summary>
        /// <para><value>/mnt/Directory01/File01.txt</value></para>
        /// </summary>
        public string N010 => @"/mnt/Directory01/File01.txt";

        /// <summary>
        /// <para><value>/mnt/Directory02/../Directory01/File01.txt</value></para>
        /// </summary>
        public string N011 => @"/mnt/Directory02/../Directory01/File01.txt";

        /// <summary>
        /// <para><value>C:\Directory01/File01.txt</value></para>
        /// </summary>
        public string N012 => @"C:\Directory01/File01.txt";

        /// <summary>
        /// <para><value></value></para>
        /// </summary>
        public string N013 => @"/mnt\Directory01\File01.txt";
    }
}
