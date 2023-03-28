using GitHub.Internals;
using Scientist.Kata.Tests;
using Xunit.Abstractions;

namespace ScientistKata.Tests.ScientistInfra;

/// <summary>
/// Unit tests implemented in classes inheriting from this
/// one will fail execution in case a Scientist experiment fails.
/// </summary>
public abstract class ScientistUnitTester : IDisposable
{
    protected readonly ITestOutputHelper _output;
    protected ScientistUnitTester(ITestOutputHelper output)
    {
        _output = output;
        if (GitHub.Scientist.ResultPublisher.GetType() == typeof(InMemoryResultPublisher))
        {
            GitHub.Scientist.ResultPublisher = new UnitTestScientistPublisher(_output);
        }

    }

    public void Dispose()
    {
    }
}