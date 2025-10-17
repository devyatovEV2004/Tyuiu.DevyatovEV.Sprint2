using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DevyatovEV.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x * x + y * y <= 1)
            {
                if (x >= 0 || y + x >= 0) return true;
                else return false;
            }
            else return false;
        }
    }
}