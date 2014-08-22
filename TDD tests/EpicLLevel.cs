using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_tests
{
    [TestClass]
    public class EpicLLevel
    {
        [TestMethod]
        public void TestTheTester()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void QuestionRetrieved()
        {
            //Arrange
            
            int ExpectedId = 1;
            int ActualId = 0;

            //Act
            ActualId = Question.Find(ExpectedId = 1);

            //Assert
            Assert.AreEqual(ExpectedId , ActualId);

            Console.WriteLine(ExpectedId);
        }

        [TestMethod]
        public void SaveResponse()
        {
            //Arrange
            
            //int StartCount = DevDatabase.Count();
            //int EndCount = 0;


            //Act
            //add to databse
            
            //EndCount = DevDatabase.Count();

            //Assert
            Assert.IsTrue(false);

            //Console.WriteLine(ExpectedId);
        }

        [TestMethod]
        public void QusstionsAreAnswered()
        {
            //Arrange

            //int StartCount = DevDatabase.Count();
            //int EndCount = 0;


            //Act
            //add to databse

            //EndCount = DevDatabase.Count();

            //Assert
            Assert.IsTrue(false);

            //Console.WriteLine(ExpectedId);

        }

        [TestMethod]
        public void UserAnswersSaved()
        {
            //Arrange

            //int StartCount = DevDatabase.Count();
            //int EndCount = 0;


            //Act
            //add to databse

            //EndCount = DevDatabase.Count();

            //Assert
            Assert.IsTrue(false);

            //Console.WriteLine(ExpectedId);
        }

        [TestMethod]
        public void DisplayUserIdealParty()
        {
            //Arrange

            //int StartCount = DevDatabase.Count();
            //int EndCount = 0;


            //Act
            //add to databse

            //EndCount = DevDatabase.Count();

            //Assert
            Assert.IsTrue(false);

            //Console.WriteLine(ExpectedId);
        }
    }
}
