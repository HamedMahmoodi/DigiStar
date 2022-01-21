using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Core.Generator
{
    public class NameGenerator
    {
        //کد منحصر به فرد 
        public static string GenerateUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
