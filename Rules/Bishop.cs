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
            while (layout.Keys.TopLeftOf(current) != null)
            {
                current = layout.Keys.TopLeftOf(current);
                moves.Add(current);
            }

            // All top right moves
            current = from;
            while (layout.Keys.TopRightOf(current) != null)
            {
                current = layout.Keys.TopRightOf(current);
                moves.Add(current);
            }

            // All bottom left moves
            current = from;
            while (layout.Keys.BottomLeftOf(current) != null)
            {
                current = layout.Keys.BottomLeftOf(current);
                moves.Add(current);
            }

            // All bottom right moves
            current = from;
            while (layout.Keys.BottomRightOf(current) != null)
            {
                current = layout.Keys.BottomRightOf(current);
                moves.Add(current);
            }

            return moves;
        }
    }
}