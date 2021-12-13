using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Pawn : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var move = layout.KeysArray.BottomOf(from);

            return move != null ?
            new List<string> {
                layout.KeysArray.BottomOf(from)
            } : new List<string>();

        }
    }
}