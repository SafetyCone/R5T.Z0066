using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Pathological
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IDirectoryNames _Raw => Raw.DirectoryNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDirectoryNames.N002"/>
        public string CurrentDirectory => _Raw.N002;

        /// <inheritdoc cref="Raw.IDirectoryNames.N003"/>
        public string ParentDirectory => _Raw.N003;

        /// <inheritdoc cref="Raw.IDirectoryNames.N001"/>
        public string WithTwoDots => _Raw.N001;
    }
}
