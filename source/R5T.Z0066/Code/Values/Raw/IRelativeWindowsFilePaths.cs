using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IRelativeWindowsFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private IRelativeFilePaths _RelativeFilePaths => RelativeFilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IRelativeFilePaths.N001"/>
        public string N001 => _RelativeFilePaths.N001;

        /// <inheritdoc cref="IRelativeFilePaths.N002"/>
        public string N002 => _RelativeFilePaths.N002;

        /// <inheritdoc cref="IRelativeFilePaths.N003"/>
        public string N003 => _RelativeFilePaths.N003;

        /// <inheritdoc cref="IRelativeFilePaths.N004"/>
        public string N004 => _RelativeFilePaths.N004;

        /// <inheritdoc cref="IRelativeFilePaths.N005"/>
        public string N005 => _RelativeFilePaths.N005;

        /// <inheritdoc cref="IRelativeFilePaths.N006"/>
        public string N006 => _RelativeFilePaths.N006;

        /// <inheritdoc cref="IRelativeFilePaths.N007"/>
        public string N007 => _RelativeFilePaths.N007;
    }
}
