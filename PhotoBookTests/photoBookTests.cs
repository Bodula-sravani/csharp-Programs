using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook.Tests
{
    [TestClass()]
    public class phoneBookTests
    {
        [TestMethod()]
        public void defaultConstructorTest()
        {
            PhotoBookClass p = new PhotoBookClass();

            if (p.GetnumberPages() == 16)
            {
                Assert.IsTrue(true);
            }
            else
            { Assert.Fail(); }
        }

        [TestMethod()]
        public void constructorTest()
        {
            int pages = 32;
            PhotoBookClass p = new PhotoBookClass(pages);
            if (p.GetnumberPages() == 32)
            {
                Assert.IsTrue(true);
            }
            else { Assert.Fail(); }
        }

        [TestMethod()]
        public void AddPhoneBookTest()
        {
            AddPhotoBook p = new AddPhotoBook();
            if (p.GetnumberPages() == 64)
            {
                Assert.IsTrue(true);
            }

            else { Assert.Fail(); }
        }
    }
}