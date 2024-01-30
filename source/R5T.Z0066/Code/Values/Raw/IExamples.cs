using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IExamples : IValuesMarker
    {
        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N0 => "";

        /// <summary>
        /// <para><value>9A19103F-16F7-4668-BE54-9A1E7A4F7556</value></para>
        /// </summary>
        public string N001 => "9A19103F-16F7-4668-BE54-9A1E7A4F7556";

        /// <summary>
        /// <para><value>R5T.Example</value></para>
        /// </summary>
        public string N002 => "R5T.Example";

        /// <summary>
        /// <para><value>An example repository.</value></para>
        /// </summary>
        public string N003 => "An example repository.";
    }
}
