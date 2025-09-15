using System;


namespace F10Y.L0032
{
    public static class Instances
    {
        public static L0020.ICommandLineOperator CommandLineOperator => L0020.CommandLineOperator.Instance;
        public static ICommandNames CommandNames => L0032.CommandNames.Instance;
    }
}