using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IPathPartSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IPathPartSets _Raw => Raw.PathPartSets.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPathPartSets.N001"/>
        public string[] C_Directory01_Directory02 => _Raw.N001;

        /// <inheritdoc cref="Raw.IPathPartSets.N002"/>
        public string[] C_Directory01_Directory02_File03_txt => _Raw.N002;
    }
}
