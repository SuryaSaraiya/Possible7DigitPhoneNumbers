using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Knight : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var moves = new List<string>();

            // bottom > bottom left
            var bblMove = layout.Keys.BottomLeftOf(layout.Keys.BottomOf(from));
            if (bblMove!= null) moves.Add(bblMove);

            // bottom > bottom right
            var bbrMove= layout.Keys.BottomRightOf(layout.Keys.BottomOf(from));
            if (bbrMove!= null) moves.Add(bbrMove);

            // bottom left > left
            var bllMove = layout.Keys.LeftOf(layout.Keys.BottomLeftOf(from));
            if (bblMove!= null) moves.Add(bblMove);

            // bottom right > right
            var brrMove = layout.Keys.RightOf(layout.Keys.BottomRightOf(from));
            if (brrMove != null) moves.Add(brrMove);

            // top > top right
            var ttrMove = layout.Keys.TopOf(layout.Keys.TopRightOf(from));
            if (ttrMove  != null) moves.Add(ttrMove);

            // top > top left
            var ttlMove = layout.Keys.TopOf(layout.Keys.TopLeftOf(from));
            if (ttlMove!= null) moves.Add(ttlMove);

            // top right > right
            var trrMove = layout.Keys.RightOf(layout.Keys.TopRightOf(from));
            if (trrMove != null) moves.Add(trrMove);

            // top left > left
            var tllMove = layout.Keys.LeftOf(layout.Keys.TopLeftOf(from));
            if (tllMove != null) moves.Add(tllMove);


            return moves;
        }
    }
}