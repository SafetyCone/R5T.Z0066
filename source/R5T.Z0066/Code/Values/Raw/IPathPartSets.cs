using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IPathPartSets : IValuesMarker
    {
        /// <summary>
        /// <list type="bullet">
        /// <item><inheritdoc cref="Z0066.IRootPaths.C_Drive" path="/summary"/></item>
        /// <item><inheritdoc cref="Z0066.IDirectoryNames.Directory01" path="/summary"/></item>
        /// <item><inheritdoc cref="Z0066.IDirectoryNames.Directory02" path="/summary"/></item>
        /// </list>
        /// </summary>
        public string[] N001 => new[]
        {
            Instances.RootPaths.C_Drive,
            Instances.DirectoryNames.Directory01,
            Instances.DirectoryNames.Directory02,
        };

        /// <summary>
        /// <list type="bullet">
        /// <item><inheritdoc cref="Z0066.IRootPaths.C_Drive" path="/summary"/></item>
        /// <item><inheritdoc cref="Z0066.IDirectoryNames.Directory01" path="/summary"/></item>
        /// <item><inheritdoc cref="Z0066.IDirectoryNames.Directory02" path="/summary"/></item>
        /// <item><inheritdoc cref="Z0066.IFileNames.File03_txt" path="/summary"/></item>
        /// </list>
        /// </summary>
        public string[] N002 => new[]
        {
            Instances.RootPaths.C_Drive,
            Instances.DirectoryNames.Directory01,
            Instances.DirectoryNames.Directory02,
            Instances.FileNames.File03_txt
        };
    }
}
