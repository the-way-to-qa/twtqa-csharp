using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using TechTalk.SpecFlow;

namespace Tests.API
{
    [Binding]
    public class TimeApiSteps
    {
        private IRestResponse _response;
        private RestClient _client;
        private RestRequest _request;

        [Given(@"I have a time api")]
        public void GivenIHaveATimeApi()
        {
            var client = new RestClient("http://worldclockapi.com/api/json/est/now");
            var request = new RestRequest(Method.GET);
            _response = client.Execute(request);
        }

        [When(@"I call the time api")]
        public void WhenICallTheTimeApi()
        {
            Assert.AreEqual(_response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [Then(@"I should get the current time")]
        public void ThenIShouldGetTheCurrentTime()
        {
            Assert.IsTrue(_response.Content.Contains("currentDateTime"));
        }
    }
}