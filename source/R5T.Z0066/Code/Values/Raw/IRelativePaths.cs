using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IRelativePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IPaths _Paths => Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N00 => @"";

        /// <inheritdoc cref="IPaths.N021"/>
        public string N000 => _Paths.N021;

        /// <summary>
        /// <para><value>..\File02.txt</value></para>
        /// </summary>
        public string N001 => @"..\File02.txt";

        /// <summary>
        /// <para><value>..\Directory02\File03.txt</value></para>
        /// </summary>
        public string N002 => @"..\Directory02\File03.txt";

        /// <summary>
        /// <para><value>..\Directory02\Directory03\File04.txt</value></para>
        /// </summary>
        public string N003 => @"..\Directory02\Directory03\File04.txt";

        /// <summary>
        /// <para><value>..\Directory04\File05.txt</value></para>
        /// </summary>
        public string N004 => @"..\Directory04\File05.txt";

        /// <summary>
        /// <para><value>..\..\File06.txt</value></para>
        /// </summary>
        public string N006 => @"..\..\File06.txt";

        /// <summary>
        /// <para><value>..\..\..\File01.txt</value></para>
        /// </summary>
        public string N007 => @"..\..\..\File01.txt";

        /// <summary>
        /// <para><value>..\</value></para>
        /// </summary>
        public string N008 => @"..\";

        /// <summary>
        /// <para><value>..\Directory02\</value></para>
        /// </summary>
        public string N009 => @"..\Directory02\";

        /// <summary>
        /// <para><value>..\Directory02\Directory03\</value></para>
        /// </summary>
        public string N010 => @"..\Directory02\Directory03\";

        /// <summary>
        /// <para><value>Directory02\</value></para>
        /// </summary>
        public string N011 => @"Directory02\";

        /// <summary>
        /// <para><value>..\Directory04\</value></para>
        /// </summary>
        public string N012 => @"..\Directory04\";

        /// <summary>
        /// <para><value>..\File01.txt</value></para>
        /// </summary>
        public string N013 => @"..\File01.txt";
    }
}
