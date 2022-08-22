using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitirmeEticaretApp.Tests
{
    [TestClass]
    public class GuidTests
    {

        [TestMethod]
        public void Are_Guids_Same()//global unique identifier- eşsiz olacak zaten
        {
            Guid guid = Guid.NewGuid();
            Guid guid2 = Guid.NewGuid();

            Assert.AreNotEqual(guid, guid2);

        }
        

    }
}
