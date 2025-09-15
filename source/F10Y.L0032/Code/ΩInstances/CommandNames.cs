using System;


namespace F10Y.L0032
{
    public class CommandNames : ICommandNames
    {
        #region Infrastructure

        public static ICommandNames Instance { get; } = new CommandNames();


        private CommandNames()
        {
        }

        #endregion
    }
}
