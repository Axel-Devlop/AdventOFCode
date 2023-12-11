using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Part2
{
    public class PuzzleSolver
    {
        private InputFromTxt input;
        private int solution;

        public PuzzleSolver(InputFromTxt Input)
        {
            this.input = Input;
            //this.solution = this.SolvePuzzle;
        }

        public InputFromTxt Input
        {
            get
            {
                return input;
            }
        }

        private int SolvePuzzle()
        {
            foreach (string Line in this.input.Input)
            {
                bool FirstNumberFound = false;
                bool SecondNumberFound = false;

                for (int i = 0; i < Line.Length; i++)
                // for every char of the line from the beginning of the line
                {
                    if (FirstNumberFound == false)
                    {
                        if (int.TryParse(this.input.Input[i], out int number))
                        //if the string of the line is a number and the first number is not found yet
                        {
                            this.solution += number * 10;
                            FirstNumberFound = true;
                        }
                        else
                        {
                            if (IsAStringANumberInLettersAsc(Line, i) != null)
                                //if the char is the first letter of a number
                            {
                                this.solution += (int)IsAStringANumberInLettersAsc(Line, i);
                                FirstNumberFound = true;
                            }
                        }
                    }
                }

                for (int i = Line.Length; i <= 0; i--)
                //for every char of the line from the end of the line
                {
                    if (SecondNumberFound == false)
                    {
                        if (int.TryParse(this.input.Input[i], out int number))
                        //if the string of the line is a number and the first number is not found yet
                        {
                            this.solution += number * 10;
                            SecondNumberFound = true;
                        }
                        else
                        {
                            if (IsAStringANumberInLettersDes(Line, i) != null)
                            //if the char is the first letter of a number
                            {
                                this.solution += (int)IsAStringANumberInLettersDes(Line, i);
                                SecondNumberFound = true;
                            }
                        }
                    }
                }
            }
        }

        public int? IsAStringANumberInLettersAsc(string String, int StartPosition)
            //Compare a substring from the StartPosition if it contain a number in letters and if yes wich one in ascendant order
        {
            try
            {
                if (String.Substring(StartPosition, 3) == "one") { return 1; }
                if (String.Substring(StartPosition, 3) == "two") { return 2; }
                if (String.Substring(StartPosition, 3) == "six") { return 6; }
                if (String.Substring(StartPosition, 4) == "zero") { return 0; }
                if (String.Substring(StartPosition, 4) == "nine") { return 9; }
                if (String.Substring(StartPosition, 4) == "four") { return 4; }
                if (String.Substring(StartPosition, 4) == "five") { return 5; }
                if (String.Substring(StartPosition, 5) == "three") { return 3; }
                if (String.Substring(StartPosition, 5) == "seven") { return 7; }
                if (String.Substring(StartPosition, 5) == "eight") { return 8; }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }

        public int? IsAStringANumberInLettersDes(string String, int StartPosition)
        //Compare a substring from the StartPosition if it contain a number in letters and if yes wich one in descendant order
        {
            try
            {
                if (String.Substring(StartPosition-2, 3) == "one") { return 1; }
                if (String.Substring(StartPosition-2, 3) == "two") { return 2; }
                if (String.Substring(StartPosition-2, 3) == "six") { return 6; }
                if (String.Substring(StartPosition-3, 4) == "zero") { return 0; }
                if (String.Substring(StartPosition-3, 4) == "nine") { return 9; }
                if (String.Substring(StartPosition-3, 4) == "four") { return 4; }
                if (String.Substring(StartPosition-3, 4) == "five") { return 5; }
                if (String.Substring(StartPosition-4, 5) == "three") { return 3; }
                if (String.Substring(StartPosition-4, 5) == "seven") { return 7; }
                if (String.Substring(StartPosition-4, 5) == "eight") { return 8; }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }
    }
}
