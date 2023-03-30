using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace csharp.qa.Drivers{
    public abstract class Driver {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Version { get; }

    }
    public abstract void lol()
    {

        Console.WriteLine("lol");
    }
}