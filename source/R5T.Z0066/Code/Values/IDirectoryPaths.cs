using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IDirectoryPaths _Raw => Raw.DirectoryPaths.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
