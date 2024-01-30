using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IRelativeFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IRelativeFilePaths _Raw => Raw.RelativeFilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
