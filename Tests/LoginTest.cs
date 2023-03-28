public class LoginTest
{
    private readonly PageFactory pageFactory;

    public LoginTest(PageFactory pageFactory) => this.pageFactory = pageFactory;

    public void LoginTest() {
        LoginPage loginPage = pageFactory.CreateLoginPage();
        loginPage.Login("username", "password");

    }

    public static void Main() {
        IWebDriver webDriver = new ChromeDriver();
        PageFactory pageFactory = new PageFactory(webDriver);
        LoginTest loginTest = new LoginTest(pageFactory);
        loginTest.LoginTest();
    }

    public void LoginTest() {
        LoginPage loginPage = pageFactory.CreateLoginPage();
        loginPage.Login("username", "password");

    }
}
