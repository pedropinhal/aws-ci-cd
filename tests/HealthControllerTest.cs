using NUnit.Framework;
using aws_ci_cd.Controllers;

namespace Tests
{
    public class HealthControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var controller = new HealthController();

            var response = controller.Get();

            Assert.That(response, Is.EqualTo("hello world"));
            
        }
    }
}