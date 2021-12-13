using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Bishop : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var moves = new List<string>();

            // All top left moves
            var current = from;
            while (layout.KeysArray.TopLeftOf(current) != null)
            {
                current = layout.KeysArray.TopLeftOf(current);
                moves.Add(current);
            }

            // All top right moves
            current = from;
            while (layout.KeysArray.TopRightOf(current) != null)
            {
                current = layout.KeysArray.TopRightOf(current);
                moves.Add(current);
            }

            // All bottom left moves
            current = from;
            while (layout.KeysArray.BottomLeftOf(current) != null)
            {
                current = layout.KeysArray.BottomLeftOf(current);
                moves.Add(current);
            }

            // All bottom right moves
            current = from;
            while (layout.KeysArray.BottomRightOf(current) != null)
            {
                current = layout.KeysArray.BottomRightOf(current);
                moves.Add(current);
            }

            return moves;
        }
    }
}