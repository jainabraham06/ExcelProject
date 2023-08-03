using System.Data;
using Helper;

namespace NewExcelProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelperClass helperClassObj = new HelperClass();
            string dtTable = helperClassObj.GetDataFromExcel();
            
        }
    }
}