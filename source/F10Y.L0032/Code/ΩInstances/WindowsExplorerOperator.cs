using System;


namespace F10Y.L0032
{
    public class WindowsExplorerOperator : IWindowsExplorerOperator
    {
        #region Infrastructure

        public static IWindowsExplorerOperator Instance { get; } = new WindowsExplorerOperator();


        private WindowsExplorerOperator()
        {
        }

        #endregion
    }
}
