using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialPandaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPandaLibrary.Tests
{
    [TestClass()]
    public class PandaTests
    {
        [TestMethod()] 
        [ExpectedException(typeof(IncorrectFormatEmailExcception))]
        public void PandaTestEmailPropertyChecker()
        {
            try
            {
                //Inserting Wrong email format
                Panda ruski = new Panda("Ivan", "rbv.bg", Gender.male);
                Assert.Fail();
            }
            catch (IncorrectFormatEmailExcception)
            {
                throw new IncorrectFormatEmailExcception();
            }
            
        }


        [TestMethod()]
        public void TestEmailProperty()
        {
            try
            {
                //Inserting correct email format
                Panda ruski = new Panda("Ivan", "ivanov961@abv.bg", Gender.male);
            }
            catch (IncorrectFormatEmailExcception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Panda ruski = new Panda("Ivan", "ruski@abv.bg", Gender.male);
            if (!(ruski.Name == "Ivan" && ruski.Email == "ruski@abv.bg" && ruski.Gender == Gender.male))
            {
                Assert.Fail();
            }
        }
    }
}