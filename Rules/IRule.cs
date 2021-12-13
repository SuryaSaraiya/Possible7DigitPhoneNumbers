using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers.Rules
{
    public interface IRule
    {
        List<string> Moves(Keypad layout, string from);
    }

}