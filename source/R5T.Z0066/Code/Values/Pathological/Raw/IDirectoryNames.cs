using System;

using R5T.T0131;


namespace R5T.Z0066.Pathological.Raw
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z0066.Raw.IDirectoryNames _DirectoryNames => Z0066.Raw.DirectoryNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z0066.Raw.IDirectoryNames.N005"/>
        public string N001 => _DirectoryNames.N005;

        /// <inheritdoc cref="Z0066.Raw.IDirectoryNames.N006"/>
        public string N002 => _DirectoryNames.N006;

        /// <inheritdoc cref="Z0066.Raw.IDirectoryNames.N007"/>
        public string N003 => _DirectoryNames.N007;
    }
}
