using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Task_IT7g2020.ConsoleApplication
{
    public class Result
    {
        public List<int> Sum;
        public Result() { }
        public Result(List<int> sum) {  this.Sum = sum; }   

        public int ResultSummary()
        { 

            int sum = 0;
            foreach (var item in Sum)
            {
                sum = sum + item;
            }
            return sum;
        }
        
    }
}
