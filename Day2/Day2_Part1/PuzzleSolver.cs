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
        private List<Bag> gameBags;

        public PuzzleSolver(string pathToPuzzleInput)
        {
            try
            {
                this.puzzleInput = File.ReadAllLines(pathToPuzzleInput);

                this.solution = 0;

                this.gameBags = new List<Bag>();

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
            CreateBagsFromInput();
        }

        private void CreateBagsFromInput()
        {
            foreach (string line in this.puzzleInput)
            {
                string[] splitLine = line.Split(':');

                string[] gameId = splitLine[0].Split(' ');
                int bagId = int.Parse(gameId[1].ToString());
                //The string is split twice to find the game number

                string[] setsOfCubes = splitLine[1].Split(';');
                Console.WriteLine("test");
            }
        }
    }
}
