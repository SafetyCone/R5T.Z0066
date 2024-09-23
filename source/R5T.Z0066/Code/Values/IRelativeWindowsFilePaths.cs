using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IRelativeWindowsFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IRelativeWindowsFilePaths _Raw => Raw.RelativeWindowsFilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
