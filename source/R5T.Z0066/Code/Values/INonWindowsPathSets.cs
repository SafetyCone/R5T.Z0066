using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface INonWindowsPathSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.INonWindowsPathSets _Raw => Raw.NonWindowsPathSets.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
