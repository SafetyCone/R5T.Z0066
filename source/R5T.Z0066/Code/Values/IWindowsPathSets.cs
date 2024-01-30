using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IWindowsPathSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IWindowsPathSets _Raw => Raw.WindowsPathSets.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// All non-pathological Windows paths.
        /// </summary>
        public string[] All_NonPathological => _Raw.N001;
    }
}
