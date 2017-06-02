using System.Linq;

namespace PrinterErrorKata
{
    public class Printer1
    {
        public string PrinterError(string s)
        {
            return s.Count(x => x > 'm') + "/" + s.Count();
        }
    }
}
