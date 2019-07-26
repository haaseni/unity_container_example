using ConsoleApp.Interfaces;

namespace ConsoleApp
{
    public class Data : IData
    {
        public string GetData()
        {
            return "From Data";
        }
    }
}
