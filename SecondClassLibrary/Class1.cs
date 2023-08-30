using System;

namespace SecondClassLibrary
{
    public class Class2
    {
        public string GetName() => typeof(Class2).Name;

        public string GetSecondName() => typeof(Class2).Name;

        //1
    }
}
