using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IRelativeWindowsDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IRelativeWindowsDirectoryPaths _Raw => Raw.RelativeWindowsDirectoryPaths.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
