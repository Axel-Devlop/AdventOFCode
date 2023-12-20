using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Part1
{
    public class Game
    {
        private int id;
        private int maxBlue = 0;
        private int maxRed = 0;
        private int maxGreen = 0;

        public Game(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return this.id; }
        }

        public int MaxBlue
        {
            get { return this.maxBlue; }
            set { this.maxBlue = value; }
        }
        public int MaxRed
        {
            get { return this.maxRed; }
            set { this.maxRed = value; }
        }
        public int MaxGreen
        {
            get { return this.maxGreen; }
            set { this.maxGreen = value; }
        }
    }
}
