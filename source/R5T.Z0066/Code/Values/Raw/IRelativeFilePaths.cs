using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IRelativeFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IRelativePaths _RelativePaths => RelativePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IRelativePaths.N001"/>
        public string N001 => _RelativePaths.N001;

        /// <inheritdoc cref="IRelativePaths.N002"/>
        public string N002 => _RelativePaths.N002;

        /// <inheritdoc cref="IRelativePaths.N003"/>
        public string N003 => _RelativePaths.N003;

        /// <inheritdoc cref="IRelativePaths.N004"/>
        public string N004 => _RelativePaths.N004;

        /// <inheritdoc cref="IRelativePaths.N006"/>
        public string N005 => _RelativePaths.N006;

        /// <inheritdoc cref="IRelativePaths.N007"/>
        public string N006 => _RelativePaths.N007;

        /// <inheritdoc cref="IRelativePaths.N013"/>
        public string N007 => _RelativePaths.N013;
    }
}
