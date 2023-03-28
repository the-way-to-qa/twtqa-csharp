public class PageFactory {
    private readonly IWebDriver _webDriver;

    public PageFactory(IWebDriver webDriver) => _webDriver = webDriver;

    public LoginPage CreateLoginPage() => new LoginPage(_webDriver);
    public HomePage CreateHomePage() => new HomePage(_webDriver);
    public ProfilePage CreateProfilePage() => new ProfilePage(_webDriver);
    public RegisterPage CreateRegisterPage() => new RegisterPage(_webDriver);
    public ResetPasswordPage CreateResetPasswordPage() => new ResetPasswordPage(_webDriver);
    public ChangePasswordPage CreateChangePasswordPage() => new ChangePasswordPage(_webDriver);
    public ChangeEmailPage CreateChangeEmailPage() => new ChangeEmailPage(_webDriver);
    public UserListPage CreateUserListPage() => new UserListPage(_webDriver);
    public UserPage CreateUserPage() => new UserPage(_webDriver);
    public UserEditPage CreateUserEditPage() => new UserEditPage(_webDriver);
    public UserDeletePage CreateUserDeletePage() => new UserDeletePage(_webDriver);
    public UserCreatePage CreateUserCreatePage() => new UserCreatePage(_webDriver);
    public RoleListPage CreateRoleListPage() => new RoleListPage(_webDriver);
    public RolePage CreateRolePage() => new RolePage(_webDriver);
    public RoleEditPage CreateRoleEditPage() => new RoleEditPage(_webDriver);
    public RoleDeletePage CreateRoleDeletePage() => new RoleDeletePage(_webDriver);
    public RoleCreatePage CreateRoleCreatePage() => new RoleCreatePage(_webDriver);
    public ClaimListPage CreateClaimListPage() => new ClaimListPage(_webDriver);
    public ClaimPage CreateClaimPage() => new ClaimPage(_webDriver);
    public ClaimEditPage CreateClaimEditPage() => new ClaimEditPage(_webDriver);
    public ClaimDeletePage CreateClaimDeletePage() => new ClaimDeletePage(_webDriver);
    public ClaimCreatePage CreateClaimCreatePage() => new ClaimCreatePage(_webDriver);
    public UserClaimListPage CreateUserClaimListPage() => new UserClaimListPage(_webDriver);
    public UserClaimPage CreateUserClaimPage() => new UserClaimPage(_webDriver);
    public UserClaimEditPage CreateUserClaimEditPage() => new UserClaimEditPage(_webDriver);
    public UserClaimDeletePage CreateUserClaimDeletePage() => new UserClaimDeletePage(_webDriver);
    public UserClaimCreatePage CreateUserClaimCreatePage() => new UserClaimCreatePage(_webDriver);
    public RoleClaimListPage CreateRoleClaimListPage() => new RoleClaimListPage(_webDriver);
    public RoleClaimPage CreateRoleClaimPage() => new RoleClaimPage(_webDriver);
    public RoleClaimEditPage CreateRoleClaimEditPage() => new RoleClaimEditPage(_webDriver);
}

