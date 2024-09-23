using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IUrls : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IUrls _Raw => Raw.Urls.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ///// <inheritdoc cref="Raw.IUrls.N000"/>
        //public string X => _Raw.N000;

        /// <inheritdoc cref="Raw.IUrls.N001"/>
        public string Example_GitHubRepositoryUrl => _Raw.N001;
    }
}
