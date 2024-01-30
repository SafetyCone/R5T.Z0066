using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface INonWindowsFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private IFilePaths _FilePaths => FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="IFilePaths.N010"/>
        public string N001 => _FilePaths.N010;

        /// <inheritdoc cref="IFilePaths.N011"/>
        public string N002 => _FilePaths.N011;

        /// <inheritdoc cref="IFilePaths.N013"/>
        public string N003 => _FilePaths.N013;
    }
}
