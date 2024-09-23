using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Pathological
{
    [ValuesMarker]
    public partial interface IPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IPaths _Raw => Raw.Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPaths.N003"/>
        public string CurrentDirectory => _Raw.N003;

        /// <inheritdoc cref="Raw.IPaths.N005"/>
        public string WithDirectoryNameWithTwoDots => _Raw.N005;

        /// <inheritdoc cref="Raw.IPaths.N001"/>
        public string Empty => _Raw.N001;

        /// <inheritdoc cref="Raw.IPaths.N002"/>
        public string Null => _Raw.N002;

        /// <inheritdoc cref="Raw.IPaths.N004"/>
        public string ParentDirectory => _Raw.N004;
    }
}
