﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PRegColGUI
{
    public static class ConfigConection
    {
        public static string connectionString =
               ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    }
}
