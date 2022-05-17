using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_nombre
{   
    public class tddnombre
    {
        public int addittion(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        public int soustraction(int number1, int number2)
        {
            var result = number1 - number2;
            return result;
        }
        public int multiplicateur(int number1, int number2)
        {
            var result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            var result = number1 / number2;
            return result;
        }

        
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = tddnombre.addittion(1,2);
            if (result == 3)
            {
                return true;
            }   
            else
            {
                return false;
            }
        }
        public void TestMethod2()
        {
            var result = tddnombre.soustraction(4, 2);
            if (result == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TestMethod3()
        {
            var result = tddnombre.multiplicateur(4, 2);
            if (result == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TestMethod4()
        {
            var result = tddnombre.division(10, 5);
            if (result == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}