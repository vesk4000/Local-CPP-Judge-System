using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_C___Judge_System
{
    public class Result
    {
        public int percent;
        public int ok;
        public List <string> testResults;
        public Result()
        {
            testResults = new List<string>();
            ok = 0;
        }
    }
}
