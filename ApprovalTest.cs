using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using System.IO;
using System.Text;
using static System.Console;
namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            
            var fakeoutput = new StringBuilder();
            SetOut(new StringWriter(fakeoutput));
            SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}
