using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Task_IT7g2020.ConsoleApplication
{
    public class Frame
    {
        public int Throw1;
        public int Throw2;
        public int Summary;

        public Frame() { }
        public Frame(int Throw1, int Throw2, int Summary)
        {
            this.Throw1 = Throw1;
            this.Throw2 = Throw2;
            this.Summary = Summary;
        }

        public int FrameSummary(int t1, int t2)
        {
            Summary = t1 + t2;
            return Summary;
        }
    }
}
