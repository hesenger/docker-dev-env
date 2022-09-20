using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DockerDevEnv.Tests;

public class Tests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public async Task CallGoogleHttpClient()
    {
        var client = new HttpClient();
        var result = await client.GetAsync("https://www.google.com");
        Assert.IsTrue(result.IsSuccessStatusCode);
    }
}
