using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IWindowsPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private IPaths _Paths => Paths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IPaths.N001"/>
        public string N001 => _Paths.N001;
    }
}
