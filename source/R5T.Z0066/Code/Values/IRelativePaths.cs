using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IRelativePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IRelativePaths _Raw => Raw.RelativePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IRelativePaths.N000"/>
        public string ToSamePath => _Raw.N000;
    }
}
