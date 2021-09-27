using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_10_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(10, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Darth Sidious", "Star Wars", 1991, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Gandalf", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Harry Potter", "Harry Potter", 1997, "J.K. Rowling")]
        [InlineData("Luna Lovegood", "Harry Potter", 2003, "J.K. Rowling")]
        [InlineData("Remus Lupin", "Harry Potter", 1999, "J.K. Rowling")]
        [InlineData("Albus Percival Wulfric Brian Dumbledore", "Harry Potter", 1997, "J.K. Rowling")]
        [InlineData("Madam Mim", "The Sword in the Stone", 1963, "Walt Disney")]
        [InlineData("Merlin", "The Sword in the Stone", 1963, "Walt Disney")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

