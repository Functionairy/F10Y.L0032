using System;

using F10Y.T0003;


namespace F10Y.L0032
{
    [ValuesMarker]
    public partial interface ICommandNames
    {
        /// <summary>
        /// "cmd" (also known as "cmd.exe")
        /// </summary>
        public string Cmd => "cmd";
    }
}
