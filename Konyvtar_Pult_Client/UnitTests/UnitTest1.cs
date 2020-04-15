using Konyvtar_Pult_Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        


        [DataRow("Lovász Kristóf")]
        [DataRow("Lovász Em3se")]
        [DataRow("Lovász !istván")]
        [DataRow("Lovász Edina")]
        [DataRow("Lovász ˇ^˘°^ˇ")]
        [DataTestMethod]
        public void NameValidation(string name)
        {
            var expected = TestName(name);
            var spf = new CheckName();
            var result = spf.CheckNameTest(name);
            Assert.AreEqual(expected, result);
        }
        public bool TestName(string name)
        {
            var punctuationsandnumbers = "`~!@#$%^&*()_+{}:<>?-=[];'./,0123456789";

            for (int i = 0; i < name.Length; i++)
            {
                if (punctuationsandnumbers.Contains(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
