using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class King : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var moves = new List<string>();

            var moveLeft = layout.Keys.LeftOf(from);
            var moveTopLeft = layout.Keys.TopLeftOf(from);
            var moveTop = layout.Keys.TopOf(from);
            var moveTopRight = layout.Keys.TopRightOf(from);
            var moveRight = layout.Keys.RightOf(from);
            var moveBottomRight = layout.Keys.BottomRightOf(from);
            var moveBottom = layout.Keys.BottomOf(from);
            var moveBottomLeft = layout.Keys.BottomLeftOf(from);

            if (moveLeft != null) moves.Add(moveLeft);
            if (moveTopLeft != null) moves.Add(moveTopLeft);
            if (moveTop != null) moves.Add(moveTop);
            if (moveTopRight != null) moves.Add(moveTopRight);
            if (moveRight != null) moves.Add(moveRight);
            if (moveBottomRight != null) moves.Add(moveBottomRight);
            if (moveBottom != null) moves.Add(moveBottom);
            if (moveBottomLeft != null) moves.Add(moveBottomLeft);


            return moves;
        }
    }
}