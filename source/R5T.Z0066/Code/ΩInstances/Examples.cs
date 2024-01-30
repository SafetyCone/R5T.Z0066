using System;


namespace R5T.Z0066
{
    public class Examples : IExamples
    {
        #region Infrastructure

        public static IExamples Instance { get; } = new Examples();


        private Examples()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class Examples : IExamples
    {
        #region Infrastructure

        public static IExamples Instance { get; } = new Examples();


        private Examples()
        {
        }

        #endregion
    }
}
