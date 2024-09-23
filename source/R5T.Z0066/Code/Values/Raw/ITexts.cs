using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface ITexts : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IStrings _Strings => Strings.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ///// <inheritdoc cref="IStrings.N001"/>
        //public string N001 => _Strings.N001;

        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N00 => @"";

        /// <inheritdoc cref="IStrings.N001"/>
        public string N001 => _Strings.N001;

        /// <inheritdoc cref="IStrings.N002"/>
        public string N002 => _Strings.N002;
    }
}
