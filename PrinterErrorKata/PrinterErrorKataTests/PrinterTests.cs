using NUnit.Framework;
using PrinterErrorKata;


namespace PrinterErrorKataTests
{
    [TestFixture]
    public class PrinterTests
    {
        [Test]
        public void PirnterError_GivesErrorCount()
        {
            var s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            var printer = new Printer();
            var result = printer.PrinterError(s);
            Assert.AreEqual("3/56",result);
        }
    }
}
