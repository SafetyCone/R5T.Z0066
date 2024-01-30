using System;

using R5T.T0131;


namespace R5T.Z0066.Pathological.Raw
{
    [ValuesMarker]
    public partial interface IFileNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z0066.Raw.IFileNames _FileNames => Z0066.Raw.FileNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z0066.Raw.IFileNames.N007"/>
        public string N001 => _FileNames.N007;

        /// <inheritdoc cref="Z0066.Raw.IFileNames.N008"/>
        public string N002 => _FileNames.N008;
    }
}
