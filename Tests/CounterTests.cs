using Bunit;
using Xunit;

public class CounterTests : BunitContext
{
    [Fact]
    public void CounterRendersAndIncrementsCorrectly()
    {
        // Act: Render the <Counter> component
        var cut = Render<Counter>();

        // Assert: Verify initial state (should display "Current count: 0")
        cut.MarkupMatches("<p role=\"status\">Current count: 0</p>");

        // Act: Find the button and click it
        cut.Find("button").Click();

        // Assert: Verify updated state (should display "Current count: 1")
        cut.MarkupMatches("<p role=\"status\">Current count: 1</p>");
    }
}