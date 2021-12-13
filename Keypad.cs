using System.Collections.Generic;

namespace Possible7DigitPhoneNumbers
{
    public record Keypad
    {        
        public List<List<string>> Keys { get; init; }
    }
}