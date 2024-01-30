using System;

using R5T.T0131;


namespace R5T.Z0066.Pathological.Raw
{
    [ValuesMarker]
    public partial interface IPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z0066.Raw.IPaths _Paths => Z0066.Raw.Paths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z0066.Raw.IPaths.N021"/>
        public string N001 => _Paths.N021;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N022"/>
        public string N002 => _Paths.N022;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N023"/>
        public string N003 => _Paths.N023;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N024"/>
        public string N004 => _Paths.N024;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N025"/>
        public string N005 => _Paths.N025;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N026"/>
        public string N006 => _Paths.N026;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N027"/>
        public string N007 => _Paths.N027;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N028"/>
        public string N008 => _Paths.N028;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N029"/>
        public string N009 => _Paths.N029;

        /// <inheritdoc cref="Z0066.Raw.IPaths.N030"/>
        public string N010 => _Paths.N030;
    }
}
