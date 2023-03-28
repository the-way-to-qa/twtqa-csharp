

public class LoginPage{
    private IWebDriver _webDriver;

    public LoginPage(IWebDriver webDriver) 
    =>  this._webDriver = webDriver;

    private IWebElement UserName => _webDriver.FindElement(By.Id("UserName"));
    private IWebElement Password => _webDriver.FindElement(By.Id("Password"));
    private IWebElement LoginButton => _webDriver.FindElement(By.XPath("//input[@type='submit']"));

    public void Login(string userName, string password){
        UserName.SendKeys(userName);
        Password.SendKeys(password);
        LoginButton.Click();
    }
}