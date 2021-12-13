using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public class Pawn : IRule
    {
        public List<string> Moves(Keypad layout, string from)
        {
            var move = layout.Keys.BottomOf(from);

            return move != null ?
            new List<string> {
                layout.Keys.BottomOf(from)
            } : new List<string>();

        }
    }
}