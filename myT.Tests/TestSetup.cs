using NUnit.Framework;
using myT.Web;



namespace TatAutomationFramework.Tests
{
    [SetUpFixture]
    public class TestSetup
    {
        
        [OneTimeSetUp]
        public void Start()
        {
            TestBase.BeginExecution();
        }

        [OneTimeTearDown]
        public void End()
        {
            TestBase.ExitExecution();
        }
    }
}