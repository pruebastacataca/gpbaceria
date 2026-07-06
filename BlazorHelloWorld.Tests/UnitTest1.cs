using Bunit;
using Xunit;
using Xunit.Abstractions;
using BlazorHelloWorld.Components.Pages;

namespace BlazorHelloWorld.Tests
{
    public class CounterTests : BunitContext
    {

        private readonly ITestOutputHelper _output;

        public CounterTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Counter_Should_Increment_Count_When_Button_Clicked()
        {
            _output.WriteLine("Dentro de prueba 1 ");
            // Arrange
            // Render the Counter component using bUnit
            var cut = Render<Counter>();

            // Find the button element and click it
            var button = cut.Find("button");

            // Act
            button.Click();

            // Assert
            // Find the paragraph that displays the count and verify its text
            var paragraph = cut.Find("p");
            paragraph.MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    

    }
}
