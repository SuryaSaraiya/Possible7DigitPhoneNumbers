using Possible7DigitPhoneNumbers.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

var key0 = new Key { Text = "0" };
var key1 = new Key { Text = "1" };
var key2 = new Key { Text = "2" };
var key3 = new Key { Text = "3" };
var key4 = new Key { Text = "4" };
var key5 = new Key { Text = "5" };
var key6 = new Key { Text = "6" };
var key7 = new Key { Text = "7" };
var key8 = new Key { Text = "8" };
var key9 = new Key { Text = "9" };
var keyStar = new Key { Text = "4" };
var keyHash = new Key { Text = "4" };

// Setup Keypad Key 1
key1.Right = key2;
key1.BottomRight = key5;
key1.Bottom = key4;

// Setup Keypad Key 2
key2.Left = key1;
key2.Right = key3;
key2.BottomRight = key6;
key2.Bottom = key5;
key2.BottomLeft = key4;

// Setup Keypad Key 3
key3.Left = key2;
key3.Bottom = key6;
key3.BottomLeft = key5;

// Setup Keypad Key 4
key4.Top = key1;
key4.TopRight = key2;
key4.Right = key5;
key4.BottomRight = key8;
key4.Bottom = key7;

// Setup Keypad Key 5
key5.Left = key4;
key5.TopLeft = key1;
key5.Top = key2;
key5.TopRight = key3;
key5.Right = key6;
key5.BottomRight = key9;
key5.Bottom = key8;
key5.BottomLeft = key7;

// Setup Keypad Key 6
key6.Left = key5;
key6.TopLeft = key2;
key6.Top = key3;
key6.Bottom = key9;
key6.BottomLeft = key8;

// Setup Keypad Key 7
key7.Top = key4;
key7.TopRight = key5;
key7.Right = key8;
key7.BottomRight = key0;
key7.Bottom = keyStar;

// Setup Keypad Key 8
key8.Left = key7;
key8.TopLeft = key4;
key8.Top = key5;
key8.TopRight = key6;
key8.Right = key9;
key8.BottomRight = keyHash;
key8.Bottom = key0;
key8.BottomLeft = keyStar;

// Setup Keypad Key 9
key9.Left = key8;
key9.TopLeft = key5;
key9.Top = key6;
key9.Bottom = keyHash;
key9.BottomLeft = key0;

// Setup Keypad Key 0
key0.Left = keyStar;
key0.TopLeft = key7;
key0.Top = key8;
key0.TopRight = key9;
key0.Right = keyHash;

// Setup Keypad Key *
keyStar.Top = key7;
keyStar.TopRight = key8;
keyStar.Right = key0;

// Setup Keypad Key #
keyHash.Left = key0;
keyHash.TopLeft = key8;
keyHash.Top = key9;


var keyPad = new Keypad
{
    Keys = new List<Key> {
        key0,
        key1,
        key2,
        key3,
        key4,
        key5,
        key6,
        key7,
        key8,
        key9,
        keyStar,
        keyHash
    },
    KeysArray = new List<List<string>> {
        new List<string> { "1","2","3" },
        new List<string> { "4","5","6" },
        new List<string> { "7","8","9" },
        new List<string> { "*","0","#" },
    }
};

var rook = new Rook();

var numbers = Enumerable.Range(2, 8).Select(n => $"{n}").ToList();

var pawnCounts = 0;
var rookCounts = 0;
var bishopCounts = 0;
var kingCounts = 0;
var queenCounts = 0;
var knightCounts = 0;

foreach (var number in numbers)
{
    pawnCounts += RG<Pawn>(new Pawn(), number.ToString(), 7);
    rookCounts += RG<Rook>(rook, number.ToString(), 7);
    bishopCounts += RG<Bishop>(new Bishop(), number.ToString(), 7);
    kingCounts += RG<King>(new King(), number.ToString(), 7);
    queenCounts+= RG<Queen>(new Queen(), number.ToString(), 7);
    knightCounts += RG<Knight>(new Knight(), number.ToString(), 7);
}

Console.WriteLine($"Pawn: {pawnCounts}");
Console.WriteLine($"Rook: {rookCounts}");
Console.WriteLine($"Bishop: {bishopCounts}");
Console.WriteLine($"King: {kingCounts}");
Console.WriteLine($"Queen: {queenCounts}");
Console.WriteLine($"Knight: {knightCounts}");
Console.ReadLine();

int RG<T>(T r, string number, int till) where T : IRule
{
    if (till == 1)
    {
        var finalsum = r.Moves(keyPad, number).Count(m => m is not "*" and not "#");
        return finalsum;
    }

    var sum = r.Moves(keyPad, number).Where(m => m is not "*" and not "#")
        .Sum(m => RG<T>(r, m, till - 1));
    return sum;

}


public record Keypad
{
    public List<Key> Keys { get; init; }
    public List<List<string>> KeysArray { get; init; }
}

public class Key
{
    public string Text { get; init; }
    public Key Left { get; set; }
    public Key TopLeft { get; set; }
    public Key Top { get; set; }
    public Key TopRight { get; set; }
    public Key Right { get; set; }
    public Key BottomRight { get; set; }
    public Key Bottom { get; set; }
    public Key BottomLeft { get; set; }
}
