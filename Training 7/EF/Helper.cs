using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Training_7.EF
{
    public static class Helper
    {
        public static String CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
