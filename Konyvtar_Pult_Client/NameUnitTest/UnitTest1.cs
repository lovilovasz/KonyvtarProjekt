using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NameUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        static Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext;

        public bool TestName(string name)
        {
            var punctuationsandnumbers = "`~!@#$%^&*()_+{}|:<>?-=[];\'.\\/,0123456789";

            for (int i = 0; i < name.Length; i++)
            {
                if (punctuationsandnumbers.Contains(name[i]))
                {
                    return false;
                }
            }
            return true;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Names.csv", "Names#csv", DataAccessMethod.Sequential), DeploymentItem("Names.csv"), TestMethod]
        public void NameValidation()
        {
            var csvname = TestContext.DataRow["name"].ToString();
            var expected = TestName(csvname);

            SearchForPatrons sfp = new SearchForPatrons();
            var result = sfp.CheckName(csvname);
            Assert.AreEqual(expected, result);

        }
    }
}