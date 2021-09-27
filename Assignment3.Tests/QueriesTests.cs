using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void WizardsAppearingInJKRowlingBooks()
        {
            List<String> expected = new List<String> { "Harry Potter", "Luna Lovegood", "Remus Lupin", "Albus Percival Wulfric Brian Dumbledore" };

            Assert.Equal(expected, Queries.returnWizardsByJKRowling_Linq());
            Assert.Equal(expected, Queries.returnWizardsByJKRowling_ExtensionMethod());
        }
        [Fact]
        public void FirstSithLordAppearance_1977()
        {
            int expected = 1977;

            Assert.Equal(expected, Queries.firstSithLordAppearance_Linq());
            Assert.Equal(expected, Queries.firstSithLordAppearance_ExtensionMethod());
        }

        [Fact]
        public void WizardsFromHarryPotter_ReturnsNameAndYear()
        {
            List<(string, int?)> expected = new List<(string, int?)> { ("Harry Potter", 1997), ("Luna Lovegood", 2003), ("Remus Lupin", 1999), ("Albus Percival Wulfric Brian Dumbledore", 1997) };

            Assert.Equal(expected, Queries.wizardsFromHarryPotter_Linq());
            Assert.Equal(expected, Queries.wizardsFromHarryPotter_ExtensionMethod());
        }

        [Fact]
        public void test()
        {
            var expected = new List<string> { "Merlin", "Madam Mim", "Sauron", "Gandalf", "Remus Lupin", "Luna Lovegood", "Harry Potter", "Albus Percival Wulfric Brian Dumbledore", "Darth Vader", "Darth Sidious" };

            Assert.Equal(expected, Queries.wizardNamesGrouped_Linq());
            Assert.Equal(expected, Queries.wizardNamesGrouped_ExtensionMethod());
        }

    }
}
