using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Queen : IRule
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

            // All top left moves
            current = from;
            while (layout.Keys.TopLeftOf(current) != null)
            {
                current = layout.Keys.TopLeftOf(current);
                moves.Add(current);
            }

            // All top  moves
            current = from;
            while (layout.Keys.TopOf(current) != null)
            {
                current = layout.Keys.TopOf(current);
                moves.Add(current);
            }

            // All top right moves
            current = from;
            while (layout.Keys.TopRightOf(current) != null)
            {
                current = layout.Keys.TopRightOf(current);
                moves.Add(current);
            }

            // All right moves
            current = from;
            while (layout.Keys.RightOf(current) != null)
            {
                current = layout.Keys.RightOf(current);
                moves.Add(current);
            }

            //All bottom right moves
            current = from;
            while (layout.Keys.BottomRightOf(current) != null)
            {
                current = layout.Keys.BottomRightOf(current);
                moves.Add(current);
            }

            // All Bottom  moves
            current = from;
            while (layout.Keys.BottomOf(current) != null)
            {
                current = layout.Keys.BottomOf(current);
                moves.Add(current);
            }

            // All Bottom Left  moves
            current = from;
            while (layout.Keys.BottomLeftOf(current) != null)
            {
                current = layout.Keys.BottomLeftOf(current);
                moves.Add(current);
            }

            return moves;
        }
    }

}