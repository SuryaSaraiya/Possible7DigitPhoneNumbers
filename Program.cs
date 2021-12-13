using System;
using System.Collections.Generic;
using System.Linq;
using Possible7DigitPhoneNumbers;
using Possible7DigitPhoneNumbers.Rules;

var keyPad = new Keypad
{
    Keys = new List<List<string>> {
        new List<string> { "1","2","3" },
        new List<string> { "4","5","6" },
        new List<string> { "7","8","9" },
        new List<string> { "*","0","#" },
    }
};


var numbers = Enumerable.Range(2, 8).Select(n => $"{n}").ToList();
var pawnCounts = 0;
var rookCounts = 0;
var bishopCounts = 0;
var kingCounts = 0;
var queenCounts = 0;
var knightCounts = 0;

foreach (var number in numbers)
{
    pawnCounts += CountAllMovesUpto<Pawn>(new Pawn(), number.ToString(), 7);
    rookCounts += CountAllMovesUpto<Rook>(new Rook(), number.ToString(), 7);
    bishopCounts += CountAllMovesUpto<Bishop>(new Bishop(), number.ToString(), 7);
    kingCounts += CountAllMovesUpto<King>(new King(), number.ToString(), 7);
    queenCounts += CountAllMovesUpto<Queen>(new Queen(), number.ToString(), 7);
    knightCounts += CountAllMovesUpto<Knight>(new Knight(), number.ToString(), 7);
}

Console.WriteLine($"Pawn: {pawnCounts}");
Console.WriteLine($"Rook: {rookCounts}");
Console.WriteLine($"Bishop: {bishopCounts}");
Console.WriteLine($"King: {kingCounts}");
Console.WriteLine($"Queen: {queenCounts}");
Console.WriteLine($"Knight: {knightCounts}");
Console.ReadLine();

int CountAllMovesUpto<T>(T r, string number, int upto) where T : IRule
{
    if (upto == 1)
    {
        var finalsum = r.Moves(keyPad, number).Count(m => m is not "*" and not "#");
        return finalsum;
    }

    var sum = r.Moves(keyPad, number).Where(m => m is not "*" and not "#")
        .Sum(m => CountAllMovesUpto<T>(r, m, upto - 1));
    return sum;
}

