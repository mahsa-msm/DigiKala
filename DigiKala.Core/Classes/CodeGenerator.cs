﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DigiKala.Core.Classes
{
    public class CodeGenerator
    {
        public static string ActiveCode()
        {
            Random random = new Random();
            return random.Next(100000, 999000).ToString();
        }
        public static string FactorCode()
        {
            Random random = new Random();
            return random.Next(10000000, 99990000).ToString();
        }
        public static string FileCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}