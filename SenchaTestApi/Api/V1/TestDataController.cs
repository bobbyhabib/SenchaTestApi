using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using SenchaTestApi.Dto;

namespace SenchaTestApi.Api.V1
{
    public class TestDataController : ApiController
    {
        [Route("api/testData/")]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(PopulateData());
        }

        public List<TestData> PopulateData()
        {
            var testCollections = new List<TestData>();

            TestData data1 = new TestData
                             {
                                 FirstName = "Bobby",
                                 LastName = "Habib",
                                 OfficeLocation = "Swindon",
                                 PhoneNumber = "07970786000"
                             };
            testCollections.Add(data1);

            TestData data2 = new TestData
                            {
                                FirstName = "John",
                                LastName = "Smith",
                                OfficeLocation = "Swindon",
                                PhoneNumber = "07970786001"
                            };

            testCollections.Add(data2);

            TestData data3 = new TestData
                            {
                                FirstName = "James",
                                LastName = "Brown",
                                OfficeLocation = "Swindon",
                                PhoneNumber = "07970786002"
                            };

            testCollections.Add(data3);

            return testCollections;

        }
    }
}