using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Cartesian_Sheet
{
    public class Algorithm 
    {
        private int GetDecimalDigitsCount(double step)
        {
            string str = step.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
            return str.Contains(".") ? str.Remove(0, Math.Truncate(step).ToString().Length + 1).Length : 0;
        }
        public List<FunctionArg> SaveToList(double from, double to, double step, double param)
        {
            double x, y;
            List<FunctionArg> list = new List<FunctionArg>();
            int toRound = GetDecimalDigitsCount(step);
            x = from;
            double l = 3 * param / Math.Sqrt(2);
            while (x <= to)
            {
                y = x * Math.Sqrt((l + x) / (l - 3 * x));
                if (!Double.IsNaN(y))
                {
                    list.Add(new FunctionArg() { X = (Math.Round(x, toRound)), Y = (Math.Round(y, 4)) });
                }
                y = -(x * Math.Sqrt((l + x) / (l - 3 * x)));
                if (!Double.IsNaN(y))
                {
                    list.Add(new FunctionArg() { X = (Math.Round(x, toRound)), Y = (Math.Round(y, 4)) });
                }
                x += step;
            }
            return list;
        }
        
        public void RightStep(ref double rightStep, double to, double from)
        {
            double distance = to - from;
            rightStep = distance / 200;
        }
        public void RightBorders(ref double fromR, ref double toR, double param)
        {
            double lenLoop = 3 * param / Math.Sqrt(2);
            double asymptote = param / Math.Sqrt(2);
            if (param > 0)
            {
                fromR = Math.Round(-lenLoop) - 1;
                toR = Math.Round(asymptote) + 1;
            }
            else
            {
                fromR = Math.Round(asymptote) - 1;
                toR = Math.Round(lenLoop) + 1;
            }
        }
    }
    public class FunctionArg
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    
}
