using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IWindowsFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private IFilePaths _FilePaths => FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IFilePaths.N001"/>
        public string N001 => _FilePaths.N001;

        /// <inheritdoc cref="IFilePaths.N002"/>
        public string N002 => _FilePaths.N002;

        /// <inheritdoc cref="IFilePaths.N003"/>
        public string N003 => _FilePaths.N003;

        /// <inheritdoc cref="IFilePaths.N004"/>
        public string N004 => _FilePaths.N004;

        /// <inheritdoc cref="IFilePaths.N005"/>
        public string N005 => _FilePaths.N005;

        /// <inheritdoc cref="IFilePaths.N006"/>
        public string N006 => _FilePaths.N006;

        /// <inheritdoc cref="IFilePaths.N007"/>
        public string N007 => _FilePaths.N007;

        /// <inheritdoc cref="IFilePaths.N008"/>
        public string N008 => _FilePaths.N008;

        /// <inheritdoc cref="IFilePaths.N009"/>
        public string N009 => _FilePaths.N009;

        /// <inheritdoc cref="IFilePaths.N012"/>
        public string N010 => _FilePaths.N012;
    }
}
