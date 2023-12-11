// See https://aka.ms/new-console-template for more information
//Console.WriteLine(File.ReadAllText(@"E:\Github Repositories\Games\AdventOfCode\Day1_Part2\Input.txt")[0]);

//Console.WriteLine(File.ReadAllLines(@"E:\Github Repositories\Games\AdventOfCode\Day1_Part2\Input.txt"));

using Day1_Part2;

InputFromTxt Input = new InputFromTxt(@"E:\Github Repositories\Games\AdventOfCode\Day1_Part2\Input.txt");

PuzzleSolver Solver = new PuzzleSolver(Input);

int? test = Solver.IsAStringANumberInLettersAsc("rvzrcjzjfour3seven16six", 8);
Console.WriteLine(test);

test = Solver.IsAStringANumberInLettersDes("rvzrcjzjfour3seven16six", 22);
Console.WriteLine(test);


/*string test = "124six";

test = test.Substring(5, -3);

Console.WriteLine(test);*/