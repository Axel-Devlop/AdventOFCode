using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Part1
{
    public class PuzzleSolver
    {
        private string[] puzzleInput;
        private int solution;

        public PuzzleSolver(string pathToPuzzleInput)
        {
            try
            {
                this.puzzleInput = File.ReadAllLines(pathToPuzzleInput);

                this.solution = 0;

                this.SolvePuzzle();
            }
            catch (Exception)
            {
                throw new Exception("Chemin du PuzzleInput invalide");
            }
            
        }

        public int Solution
        {
            get
            {
                return this.solution;
            }
        }

        private void SolvePuzzle()
        {
            foreach (string line in this.puzzleInput)
            {

            }
        }
    }
}
