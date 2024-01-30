using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Pathological.IDirectoryNames _Pathological => Pathological.DirectoryNames.Instance;
        public Raw.IDirectoryNames _Raw => Raw.DirectoryNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDirectoryNames.N001"/>
        public string Directory01 => _Raw.N001;

        /// <inheritdoc cref="Raw.IDirectoryNames.N002"/>
        public string Directory02 => _Raw.N002;

        /// <inheritdoc cref="Raw.IDirectoryNames.N003"/>
        public string Directory03 => _Raw.N003;

        /// <inheritdoc cref="Raw.IDirectoryNames.N004"/>
        public string Directory04 => _Raw.N004;
    }
}
