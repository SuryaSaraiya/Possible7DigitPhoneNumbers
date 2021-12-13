using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Rook : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var moves = new List<string>();

            // All left moves
            var current = from;
            while (layout.Keys.LeftOf(current) != null)
            {
                current = layout.Keys.LeftOf(current);
                moves.Add(current);
            }

            // All right moves
            current = from;
            while (layout.Keys.RightOf(current) != null)
            {
                current = layout.Keys.RightOf(current);
                moves.Add(current);
            }

            // All top  moves
            current = from;
            while (layout.Keys.TopOf(current) != null)
            {
                current = layout.Keys.TopOf(current);
                moves.Add(current);
            }

            // All Bottom  moves
            current = from;
            while (layout.Keys.BottomOf(current) != null)
            {
                current = layout.Keys.BottomOf(current);
                moves.Add(current);
            }

            return moves;
        }
    }
}