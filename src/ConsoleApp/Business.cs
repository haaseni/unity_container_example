using ConsoleApp.Interfaces;

namespace ConsoleApp
{
    public class Business : IBusiness
    {
        IData _data;

        public Business(IData data)
        {
            _data = data;
        }

        public string GetBusinessData()
        {
            return _data.GetData();
        }
    }
}
