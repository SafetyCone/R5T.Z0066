using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IWindowsPathSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IWindowsPaths _WindowsPaths => WindowsPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string[] N001 => new[]
        {
            _WindowsPaths.N001,
        };
    }
}
