using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    /// <summary>
    /// Contains numbered paths.
    /// </summary>
    /// <remarks>
    /// Prior work:
    /// * R5T.Salamis
    /// </remarks>
    [ValuesMarker]
    public partial interface IPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IDirectoryNames _DirectoryNames => DirectoryNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N0 => @"";

        /// <summary>
        /// <para><value>C:\Directory01</value></para>
        /// </summary>
        public string N001 => @"C:\Directory01";

        /// <summary>
        /// <para><value>C:\Directory01\</value></para>
        /// </summary>
        public string N002 => @"C:\Directory01\";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02</value></para>
        /// </summary>
        public string N003 => @"C:\Directory01\Directory02";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\</value></para>
        /// </summary>
        public string N004 => @"C:\Directory01\Directory02\";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03</value></para>
        /// </summary>
        public string N005 => @"C:\Directory01\Directory02\Directory03";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03\</value></para>
        /// </summary>
        public string N006 => @"C:\Directory01\Directory02\Directory03\";

        /// <summary>
        /// <para><value>C:\Directory01\Directory04</value></para>
        /// </summary>
        public string N007 => @"C:\Directory01\Directory04";

        /// <summary>
        /// <para><value>C:\Directory01\Directory04\</value></para>
        /// </summary>
        public string N008 => @"C:\Directory01\Directory04\";

        /// <summary>
        /// <para><value>C:</value></para>
        /// </summary>
        public string N009 => @"C:";

        /// <summary>
        /// <para><value>C:\</value></para>
        /// </summary>
        public string N010 => @"C:\";

        /// <summary>
        /// <para><value>C:\Directory04\..\Directory01\</value></para>
        /// </summary>
        public string N011 => @"C:\Directory04\..\Directory01\";

        /// <summary>
        /// <para><value>/mnt/Directory01</value></para>
        /// </summary>
        public string N012 => @"/mnt/Directory01";

        /// <summary>
        /// <para><value>/mnt/Directory01/</value></para>
        /// </summary>
        public string N013 => @"/mnt/Directory01/";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02</value></para>
        /// </summary>
        public string N014 => @"/mnt/Directory01/Directory02";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/</value></para>
        /// </summary>
        public string N015 => @"/mnt/Directory01/Directory02/";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/Directory03</value></para>
        /// </summary>
        public string N016 => @"/mnt/Directory01/Directory02/Directory03";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/Directory03/</value></para>
        /// </summary>
        public string N017 => @"/mnt/Directory01/Directory02/Directory03/";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory04</value></para>
        /// </summary>
        public string N018 => @"/mnt/Directory01/Directory04";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory04/</value></para>
        /// </summary>
        public string N019 => @"/mnt/Directory01/Directory04/";

        /// <summary>
        /// <para><value>/mnt/Directory04/../Directory01/</value></para>
        /// </summary>
        public string N020 => @"/mnt/Directory04/../Directory01/";

        /// <summary>
        /// <para><value>"" (the empty path)</value></para>
        /// </summary>
        public string N021 => @"";

        /// <summary>
        /// <para><value>&lt;null&gt; (the null path)</value></para>
        /// </summary>
        public string N022 => null;

        /// <inheritdoc cref="IDirectoryNames.N006"/>
        public string N023 => _DirectoryNames.N006;

        /// <inheritdoc cref="IDirectoryNames.N007"/>
        public string N024 => _DirectoryNames.N007;

        /// <summary>
        /// <para><value>C:\Temp\Directory..Name\</value></para>
        /// </summary>
        public string N025 => @"C:\Temp\Directory..Name\";

        /// <summary>
        /// <para><value>"&lt;" (the less-than sign, an invalid path)</value></para>
        /// </summary>
        public string N026 => @"<";

        /// <summary>
        /// <para><value>C:\Temp\Proje&lt;ts\R5T.Z0004\</value></para>
        /// A pathological path with an invalid file name character in one of its path parts.
        /// </summary>
        public string N027 => @"C:\Temp\Proje<ts\R5T.Z0004\";

        /// <summary>
        /// <para><value>C:\Temp\..Folder\..File.txt</value></para>
        /// A valid path with a folder name and file name that start with two dots.
        /// </summary>
        public string N028 => @"C:\Temp\..Folder\..File.txt";

        /// <summary>
        /// <para><value>C:\Temp\Folder.\File.txt</value></para>
        /// An invalid path containing a directory name ending with the current directory name.
        /// </summary>
        public string N029 => @"C:\Temp\Folder.\File.txt";

        /// <summary>
        /// <para><value>C:\Temp\Folder\File..</value></para>
        /// An invalid path containing a file name ending with the parent directory name.
        /// </summary>
        public string N030 => @"C:\Temp\Folder\File..";
    }
}
