using GitHub;
using Xunit.Abstractions;

namespace ScientistKata.Tests.ScientistInfra;

/// <summary>
/// Logs the outcome of the experiment so it appears in unit test logs
/// And throws an exception when experiment failed, failing unit test as well.
/// </summary>
public class UnitTestScientistPublisher : IResultPublisher
{
    private readonly ITestOutputHelper _output;

    public UnitTestScientistPublisher(ITestOutputHelper output)
    {
        _output = output;
    }

    public Task Publish<T, TClean>(Result<T, TClean> result)
    {
        _output.WriteLine($"Publishing results for experiment '{result.ExperimentName}'");

        _output.WriteLine($"Result: {(result.Matched ? "MATCH" : "MISMATCH")}");
        _output.WriteLine($"Control value: {result.Control.Value}");
        _output.WriteLine($"Control duration: {result.Control.Duration}");
        foreach (var observation in result.Candidates)
        {
            _output.WriteLine($"Candidate name: {observation.Name}");
            _output.WriteLine($"Candidate value: {observation.Value}");
            _output.WriteLine($"Candidate duration: {observation.Duration}");
        }

        if (result.Mismatched)
        {
            _output.WriteLine("Mismatch!");
            throw new Exception("Scientist experiment results differ.");
        }

        return Task.FromResult(0);
    }
}