using System;

using R5T.T0131;


namespace R5T.Z0066
{
    [ValuesMarker]
    public partial interface IExamples : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IExamples _Raw => Raw.Examples.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IExamples.N001"/>
        public string GuidString => _Raw.N001;

        /// <inheritdoc cref="Raw.IExamples.N002"/>
        public string LibraryName => _Raw.N002;

        /// <inheritdoc cref="Raw.IExamples.N002"/>
        public string ProjectName => _Raw.N002;

        /// <inheritdoc cref="Raw.IExamples.N002"/>
        public string RepsitoryName => _Raw.N002;

        /// <inheritdoc cref="Raw.IExamples.N003"/>
        public string RepositoryDescription => _Raw.N003;
    }
}
