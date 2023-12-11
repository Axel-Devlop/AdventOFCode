using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Part2
{
    public class InputFromTxt
    {
        private string[] input;
        /// <summary>
        /// An Array containing every line of the txt file
        /// </summary>
        /// <param name="PathToTxt">The Path of the txt file where the input is</param>

        public InputFromTxt(string PathToTxt)
        {
            input = File.ReadAllLines(PathToTxt);
        }

        public string[] Input
        {
            get
            {
                return input;
            }
        }
    }
}
