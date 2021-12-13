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
            while (layout.KeysArray.LeftOf(current) != null)
            {
                current = layout.KeysArray.LeftOf(current);
                moves.Add(current);
            }

            // All right moves
            current = from;
            while (layout.KeysArray.RightOf(current) != null)
            {
                current = layout.KeysArray.RightOf(current);
                moves.Add(current);
            }

            // All top  moves
            current = from;
            while (layout.KeysArray.TopOf(current) != null)
            {
                current = layout.KeysArray.TopOf(current);
                moves.Add(current);
            }

            // All Bottom  moves
            current = from;
            while (layout.KeysArray.BottomOf(current) != null)
            {
                current = layout.KeysArray.BottomOf(current);
                moves.Add(current);
            }

            return moves;
        }
    }
}