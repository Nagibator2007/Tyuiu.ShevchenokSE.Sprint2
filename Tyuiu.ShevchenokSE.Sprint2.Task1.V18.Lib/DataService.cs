using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShevchenokSE.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a < b) | (b == d);
            result[1] = (b > d) & (b != a);
            result[2] = (a >= c) || (a != d);
            result[3] = (b != c) && (b < c);
            result[4] = !(b == c);
            result[5] = (b >= d) ^ (d != c);
            return result;
        }
    }
}