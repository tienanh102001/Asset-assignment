using CoreFramework.NUnitTestSetup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.TestSetup
{
    public class ProjectNUnitTestSetup : NUnitTestSetup
    {
        [SetUp]
        public void SetUp()
        {
            driverBaseAction.GoToUrl(Constant.BASE_URL);

        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
