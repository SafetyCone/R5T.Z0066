using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Pathological
{
    [ValuesMarker]
    public partial interface IFileNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IFileNames _Raw => Raw.FileNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IFileNames.N001"/>
        public string File01_WithoutExtension => _Raw.N001;

        /// <inheritdoc cref="Raw.IFileNames.N002"/>
        public string WithTwoFileExtensionSeparatorDots => _Raw.N002;
    }
}
