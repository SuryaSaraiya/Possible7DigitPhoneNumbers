namespace Possible7DigitPhoneNumbers
{
    public class Key
    {
        public string Text { get; init; }
        public Key Left { get; set; }
        public Key TopLeft { get; set; }
        public Key Top { get; set; }
        public Key TopRight { get; set; }
        public Key Right { get; set; }
        public Key BottomRight { get; set; }
        public Key Bottom { get; set; }
        public Key BottomLeft { get; set; }
    }
}