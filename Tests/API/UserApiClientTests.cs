using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;

[TestClass]
public class UserApiClientTests 
{
    private UserApiClient _userApiClient;

    [TestInitialize]
    public void Init() {
        var httpClient = new HttpClient();
        _userApiClient = new UserApiClient(httpClient);
    }

    [TestMethod]
    public async Task GetUserAsync_ReturnsOk() {
        var userId = 123;
        var response = await _userApiClient.GetUserAsync(userId);
        Assert.IsTrue(response.IsSuccessStatusCode);
    }

}