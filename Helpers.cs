using System.Collections.Generic;
using System.Linq;

namespace Possible7DigitPhoneNumbers
{
    public static class Helpers
    {
        private static (int, int) GetPositionOf(this List<List<string>> keyPad, string key)
        {
            var keyRow = keyPad.FindIndex(r => r.Any(k => k == key));
            var keyCol = keyPad[keyRow].FindIndex(k => k == key);
            return (keyRow, keyCol);
        }
        public static string LeftOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyCol <= 0 ? default : keyPad[keyRow][keyCol - 1];
        }

        public static string TopLeftOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyRow > 0 && keyCol > 0 ? keyPad[keyRow - 1][keyCol - 1] : default;
        }

        public static string TopOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyRow <= 0 ? default : keyPad[keyRow - 1][keyCol];
        }

        public static string TopRightOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyRow > 0 && keyCol < keyPad[0].Count - 1 ? keyPad[keyRow - 1][keyCol + 1] : default;
        }

        public static string RightOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyCol >= keyPad[0].Count - 1 ? default : keyPad[keyRow][keyCol + 1];
        }

        public static string BottomRightOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyRow < keyPad.Count - 1 && keyCol < keyPad[0].Count - 1 ? keyPad[keyRow + 1][keyCol + 1] : default;
        }

        public static string BottomOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyRow >= keyPad.Count - 1 ? default : keyPad[keyRow + 1][keyCol];
        }

        public static string BottomLeftOf(this List<List<string>> keyPad, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return default;
            }
            var (keyRow, keyCol) = keyPad.GetPositionOf(key);
            return keyRow < keyPad.Count - 1 && keyCol > 0 ? keyPad[keyRow + 1][keyCol - 1] : default;
        }
    }
}