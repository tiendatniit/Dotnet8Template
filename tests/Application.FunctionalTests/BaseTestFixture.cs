namespace Dotnet8Template.Application.FunctionalTests;

using static Testing;

[TestFixture]
public abstract class BaseTestFixture
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
