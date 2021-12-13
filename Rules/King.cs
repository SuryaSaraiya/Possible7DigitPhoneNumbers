using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class King : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var moves = new List<string>();

            var moveLeft = layout.KeysArray.LeftOf(from);
            var moveTopLeft = layout.KeysArray.TopLeftOf(from);
            var moveTop = layout.KeysArray.TopOf(from);
            var moveTopRight = layout.KeysArray.TopRightOf(from);
            var moveRight = layout.KeysArray.RightOf(from);
            var moveBottomRight = layout.KeysArray.BottomRightOf(from);
            var moveBottom = layout.KeysArray.BottomOf(from);
            var moveBottomLeft = layout.KeysArray.BottomLeftOf(from);

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