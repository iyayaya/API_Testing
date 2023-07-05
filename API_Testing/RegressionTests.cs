using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using APIResponse;

namespace APITesting
{
    [TestClass]
    public class RegressionTests
    {
        [TestMethod]
        // Checking of Category Name and CanRelist value
        public void VerifyNameAndCanRelistValue()
        {
            var proj = new API_Response();
            var response = proj.GetUsers();
            Assert.AreEqual(6329, response.CategoryId);
            Assert.AreEqual("Home & garden", response.Name);
            Assert.AreEqual(true, response.CanRelist);
        }

        [TestMethod]
        // Checking of Promotion/Descriptions based on Promotion Name
        public void VerifyDescription()
        {
            var proj = new API_Response();
            var response = proj.GetUsers();

            // Loop through each Promotion
            for (int i = 0; i < response.Promotions.Length; i++)
            {
                switch(response.Promotions[i].Name)
                {
                    case "Basic":
                        Assert.AreEqual("Lowest position in category", response.Promotions[i].Description);
                        break;

                    case "Gallery":
                        Assert.AreEqual("Good position in category", response.Promotions[i].Description);
                        break;

                    case "Feature":
                        Assert.AreEqual("Better position in category", response.Promotions[i].Description);
                        break;

                    case "Feature Combo":
                        Assert.AreEqual("Best position in category \nIncludes benefits of Feature \nHighlights listing in search results", response.Promotions[i].Description);
                        break;

                    default:
                        Assert.Fail();
                        break;
                }
            }
        }
    }
}
