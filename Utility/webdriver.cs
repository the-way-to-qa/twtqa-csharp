using System;
using System.Collections.Generic;
using Selenium.WebDriver;


public class WebDriver {
    private IWebDriver _webDriver;
    private WebDriverWait _webDriverWait;
    public override Uri Url => new Uri(_webDriver.Url);
}