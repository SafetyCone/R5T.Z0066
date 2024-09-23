using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IRelativeDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IRelativeDirectoryPaths _Raw => Raw.RelativeDirectoryPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
