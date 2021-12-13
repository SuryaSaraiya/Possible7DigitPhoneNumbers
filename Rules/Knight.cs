using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Knight : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var moves = new List<string>();

            // bottom > bottom left
            var bblMove = layout.KeysArray.BottomLeftOf(layout.KeysArray.BottomOf(from));
            if (bblMove!= null) moves.Add(bblMove);

            // bottom > bottom right
            var bbrMove= layout.KeysArray.BottomRightOf(layout.KeysArray.BottomOf(from));
            if (bbrMove!= null) moves.Add(bbrMove);

            // bottom left > left
            var bllMove = layout.KeysArray.LeftOf(layout.KeysArray.BottomLeftOf(from));
            if (bblMove!= null) moves.Add(bblMove);

            // bottom right > right
            var brrMove = layout.KeysArray.RightOf(layout.KeysArray.BottomRightOf(from));
            if (brrMove != null) moves.Add(brrMove);

            // top > top right
            var ttrMove = layout.KeysArray.TopOf(layout.KeysArray.TopRightOf(from));
            if (ttrMove  != null) moves.Add(ttrMove);

            // top > top left
            var ttlMove = layout.KeysArray.TopOf(layout.KeysArray.TopLeftOf(from));
            if (ttlMove!= null) moves.Add(ttlMove);

            // top right > right
            var trrMove = layout.KeysArray.RightOf(layout.KeysArray.TopRightOf(from));
            if (trrMove != null) moves.Add(trrMove);

            // top left > left
            var tllMove = layout.KeysArray.LeftOf(layout.KeysArray.TopLeftOf(from));
            if (tllMove != null) moves.Add(tllMove);


            return moves;
        }
    }
}