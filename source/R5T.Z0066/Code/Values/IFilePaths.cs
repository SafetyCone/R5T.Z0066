using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IFilePaths _Raw => Raw.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IFilePaths.N003"/>
        public string C_Directory01_Directory02_File03_txt => _Raw.N003;
    }
}
