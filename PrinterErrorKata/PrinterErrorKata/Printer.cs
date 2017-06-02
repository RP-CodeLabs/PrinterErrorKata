using System.Linq;

namespace PrinterErrorKata
{
    public class Printer
    {
        public const string Error = "nopqrstuvwxyz";
        public string PrinterError1(string s)
        {
            var chars = s.ToCharArray();
            var count = chars.Count(x => Error.Contains(x));
            return $"{count}/{chars.Length}";
        }
    }
}