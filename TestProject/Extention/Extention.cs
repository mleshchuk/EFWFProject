using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject.Extention
{
    static class Extention
    {
        public static IEnumerable<string> ToStringCollection(this MatchCollection mc)
        {
            if (mc != null)
            {
                foreach (Match m in mc)
                    yield return m.ToString();
            }
        }
    }
}
