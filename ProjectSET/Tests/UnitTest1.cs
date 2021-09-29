using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectSET;


namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToStringTest()
        {
            //arrange
            MySet<int> set2 = new MySet<int>() { 1, 2, 3 };

            //act
            string str = set2.ToString();

            //assert
            Assert.AreEqual("1,2,3", str);
        }
        [TestMethod]
        public void ParametrizedToStringTest()
        {
            //arrange
            MySet<int> set2 = new MySet<int>() { 1, 2, 3 };

            //act
            string str = set2.ToString('.');

            //assert
            Assert.AreEqual("1.2.3", str);
        }
        [TestMethod]
        public void AddTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>();
            int item = 10;

            //act
            set1.Add(item);

            //assert
            Assert.AreEqual(item.ToString(), set1.ToString()); // is 10 == 10?

        }
        [TestMethod]
        [ExpectedException(typeof(AddRemoveNullElementException))]
        public void AddNullItemTest()
        {
            //arrange
            MySet<string> set1 = new MySet<string>();
            string item = null;

            //act
            set1.Add(item);

            //assert Expects exception
        }
        [TestMethod]
        public void RemoveTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2, 3};
            int item = 2;

            //act
            set1.Remove(item);

            //assert
            Assert.AreEqual("1,3", set1.ToString());
        }
        [TestMethod]
        [ExpectedException(typeof(AddRemoveNullElementException))]
        public void RemoveNullArgumentTest()
        {
            //arrange
            MySet<string> set1 = new MySet<string>() { "1", "2", "3" };
            string item = null;

            //act
            set1.Remove(item);

            //assert
            Assert.AreEqual("1,3", set1.ToString());
        }
        [TestMethod]
        public void IsEmptyTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1 };
            int item = 1;

            //act
            set1.Remove(item);

            //assert
            Assert.AreEqual("Empty", set1.ToString());
        }
        [TestMethod]
        [ExpectedException(typeof(RemoveFromEmptySetException))]
        public void RemoveEmptySetTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>();
            int item = 2;

            //act
            set1.Remove(item);
           
            //assert Expects exception

        }
        [TestMethod]
        [ExpectedException(typeof(ItemNotFoundException))]
        public void RemoveNotExistTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 3 };
            int item = 2;
            bool Caught = false;
            //act
            set1.Remove(item);
            //assert expects exception
        }

        [TestMethod]
        public void UnionTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2 };
            MySet<int> set2 = new MySet<int>() { 3, 4 };
            MySet<int> res = new MySet<int>();
            //act
            res = MySet<int>.Union(set1, set2);
            bool first = "1,2,3,4" == res.ToString();
            res = MySet<int>.Union(set2, set1);
            bool second = "3,4,1,2" == res.ToString();

            //assert
            Assert.IsTrue(first && second);
            
        }
        [TestMethod]
        public void UnionNullResultTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2 };
            MySet<int> set2 = new MySet<int>();
            MySet<int> res = new MySet<int>();
            //act
            res = MySet<int>.Union(set1, set2);
            bool first = "1,2" == res.ToString();
            res = MySet<int>.Union(set2, set1);
            bool second = "1,2" == res.ToString();

            //assert
            Assert.IsTrue(first && second);

        }
        [TestMethod]
        public void IntersectionTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2, 3 };
            MySet<int> set2 = new MySet<int>() { 3, 4, 5 };
            MySet<int> res = new MySet<int>();
            //act
            res = MySet<int>.Intersection(set1, set2);
            bool first = "3" == res.ToString();
            res = MySet<int>.Intersection(set2, set1);
            bool second = "3" == res.ToString();

            //assert
            Assert.IsTrue(first && second);
        }
        [TestMethod]
        public void DifferenceTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2, 3, 4};
            MySet<int> set2 = new MySet<int>() { 1, 2, 3};
            MySet<int> res = new MySet<int>();
            //act
            res = MySet<int>.Difference(set1, set2);
            bool first = "4" == res.ToString();
            res = MySet<int>.Difference(set2, set1);
            bool second = "Empty" == res.ToString();

            //assert
            Assert.IsTrue(first && second);
        }
        [TestMethod]
        public void SubsetYesTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2, 3 };
            MySet<int> set2 = new MySet<int>() { 1, 2, 3, 4 };
            //act
            
            bool first = MySet<int>.Subset(set1, set2);

            //assert
            Assert.IsTrue(first);
        }
        [TestMethod]
        public void SubsetNoTest()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2, 3, 4 };
            MySet<int> set2 = new MySet<int>() { 1, 2, 3 };
            //act

            bool first = MySet<int>.Subset(set1, set2);

            //assert
            Assert.IsTrue(!first);
        }
        [TestMethod]
        public void IsBelong()
        {
            //arrange
            MySet<int> set1 = new MySet<int>() { 1, 2, 3 };
            int item = 2;
            //act

            bool first = MySet<int>.Subset(new MySet<int>() { item }, set1);

            //assert
            Assert.IsTrue(first);
        }

    }
}
