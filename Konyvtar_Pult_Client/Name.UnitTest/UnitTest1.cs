using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Name.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        

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
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data\Names.csv", "Names#csv", DataAccessMethod.Sequential)]
        public void NameValidation()
        {
            var csvname = TestContext.DataRow["name"].ToString();
            var expected = TestName(csvname);
            var result = new Konyvtar_Pult_client();
            Assert.AreEqual(expected, result);

        }
    }
}
