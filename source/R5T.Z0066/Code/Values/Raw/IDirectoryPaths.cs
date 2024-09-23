using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IPaths _Paths => Raw.Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IPaths.N001"/>
        public string N001 => _Paths.N001;

        /// <inheritdoc cref="IPaths.N002"/>
        public string N002 => _Paths.N002;

        /// <inheritdoc cref="IPaths.N003"/>
        public string N003 => _Paths.N003;

        /// <inheritdoc cref="IPaths.N004"/>
        public string N004 => _Paths.N004;

        /// <inheritdoc cref="IPaths.N005"/>
        public string N005 => _Paths.N005;

        /// <inheritdoc cref="IPaths.N006"/>
        public string N006 => _Paths.N006;

        /// <inheritdoc cref="IPaths.N007"/>
        public string N007 => _Paths.N007;

        /// <inheritdoc cref="IPaths.N008"/>
        public string N008 => _Paths.N008;

        /// <inheritdoc cref="IPaths.N009"/>
        public string N009 => _Paths.N009;

        /// <inheritdoc cref="IPaths.N010"/>
        public string N010 => _Paths.N010;

        /// <inheritdoc cref="IPaths.N011"/>
        public string N011 => _Paths.N011;

        /// <inheritdoc cref="IPaths.N012"/>
        public string N012 => _Paths.N012;

        /// <inheritdoc cref="IPaths.N013"/>
        public string N013 => _Paths.N013;

        /// <inheritdoc cref="IPaths.N014"/>
        public string N014 => _Paths.N014;

        /// <inheritdoc cref="IPaths.N015"/>
        public string N015 => _Paths.N015;

        /// <inheritdoc cref="IPaths.N016"/>
        public string N016 => _Paths.N016;

        /// <inheritdoc cref="IPaths.N017"/>
        public string N017 => _Paths.N017;

        /// <inheritdoc cref="IPaths.N018"/>
        public string N018 => _Paths.N018;

        /// <inheritdoc cref="IPaths.N019"/>
        public string N019 => _Paths.N019;

        /// <inheritdoc cref="IPaths.N020"/>
        public string N020 => _Paths.N020;
    }
}
