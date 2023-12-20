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
        private List<Game> games;

        public PuzzleSolver(string pathToPuzzleInput)
        {
            try
            {
                this.puzzleInput = File.ReadAllLines(pathToPuzzleInput);

                this.solution = 0;

                this.games = new List<Game>();

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
            // The Elf would first like to know which games would have been possible if the bag contained only 12 red cubes, 13 green cubes, and 14 blue cubes?

            foreach (Game game in this.games)
            {
                if(game.MaxRed <= 12 && game.MaxGreen <= 13 && game.MaxBlue <= 14)
                {
                    this.solution += game.Id;
                }
            }
            Console.WriteLine(this.solution);
        }

        private void CreateBagsFromInput()
        {
            foreach (string line in this.puzzleInput)
            {
                string[] splitLine = line.Split(':');

                string[] gameId = splitLine[0].Split(' ');
                int bagId = int.Parse(gameId[1].ToString());
                //The string is split twice to find the game id
                Game newGame = new Game(bagId);

                string[] setsOfCubes = splitLine[1].Split(';');

                foreach (string setOfCubes in setsOfCubes)
                {
                    string[] rawCubes = setOfCubes.Trim().Split(',');

                    foreach (string cubes in rawCubes)
                    {
                        string[] numberAndCube = cubes.Trim().Split(' ');
                        // numberAndCube[0] is the number of cubes
                        // numberAndCube[1] is the color of the cubes

                        switch (numberAndCube[1])
                        {
                            case "blue": 
                                if (int.Parse(numberAndCube[0]) > newGame.MaxBlue) { newGame.MaxBlue = int.Parse(numberAndCube[0]); }
                                break;

                            case "red":
                                if (int.Parse(numberAndCube[0]) > newGame.MaxRed) { newGame.MaxRed = int.Parse(numberAndCube[0]); }
                                break;

                            case "green":
                                if (int.Parse(numberAndCube[0]) > newGame.MaxGreen) { newGame.MaxGreen = int.Parse(numberAndCube[0]); }
                                break;

                            default: throw new Exception("Invalid cube color");
                        }
                    }
                }

                this.games.Add(newGame);
            }
        }
    }
}
