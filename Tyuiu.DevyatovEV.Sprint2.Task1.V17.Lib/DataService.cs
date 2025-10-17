using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DevyatovEV.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) & (c != d);
            res[1] = (a == b) | (c < d);
            res[2] = (a <= c) && (d >= b);
            res[3] = (a != d) ^ (b == c);
            res[4] = (c > a) & (b < d);
            res[5] = (a >= c) | (d <= b);

            return res;
        }
    }
}
