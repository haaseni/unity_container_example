﻿namespace ConsoleApp
{
    public class Initiator
    {
        IBusiness _business;

        public Initiator(IBusiness business)
        {
            _business = business;
        }

        public string FetchData()
        {
            return _business.GetBusinessData();
        }
    }
}
