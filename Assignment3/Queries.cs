
using System;
using System.Collections.Generic;
using System.Linq;
namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IEnumerable<String> returnWizardsByJKRowling_Linq()
        {
            var wizards = Wizard.Wizards.Value;

            var query = from w in wizards
                        where w.Creator.Contains("Rowling")
                        select w.Name;

            foreach (var item in query)
            {
                yield return item;
            }
        }

        public static int? firstSithLordAppearance_Linq()
        {
            var wizards = Wizard.Wizards.Value;

            var query = (from w in wizards
                         where w.Name.StartsWith("Darth")
                         orderby w.Year ascending
                         select w.Year);

            return query.First();
        }

        public static List<(string, int?)> wizardsFromHarryPotter_Linq()
        {
            var wizards = Wizard.Wizards.Value;
            List<(string, int?)> result = new List<(string, int?)>();

            var query = from w in wizards
                        where w.Medium.Equals("Harry Potter")
                        select new { Name = w.Name, Year = w.Year };

            foreach (var item in query)
            {
                result.Add((item.Name, item.Year));
            }
            return result;
        }


        public static List<string> wizardNamesGrouped_Linq()
        {
            //Grouped by creator in reverse ordered by creator name and then wizard name.
            var wizards = Wizard.Wizards.Value;
            List<string> result = new List<string>();

            var query = from w in wizards
                        orderby w.Creator descending, w.Name descending
                        group w.Name by w.Creator into g
                        select g;

            foreach (var group in query)
            {
                foreach (var wizard in group.ToList())
                {
                    result.Add(wizard);
                }
            }

            return result;

        }




        public static IEnumerable<String> returnWizardsByJKRowling_ExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;
            var query = wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);

            foreach (var item in query)
            {
                yield return item;
            }
        }

        public static int? firstSithLordAppearance_ExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;

            var query = wizards.Where(w => w.Name.StartsWith("Darth")).OrderBy(w => w.Year).Select(w => w.Year).Take(1);

            return query.First();
        }

        public static List<(string, int?)> wizardsFromHarryPotter_ExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;
            List<(string, int?)> result = new List<(string, int?)>();

            var query = wizards.Where(w => w.Medium.Equals("Harry Potter")).Select(w => new { Name = w.Name, Year = w.Year });

            foreach (var item in query)
            {
                result.Add((item.Name, item.Year));
            }
            return result;
        }


        public static List<string> wizardNamesGrouped_ExtensionMethod()
        {
            //Grouped by creator in reverse ordered by creator name and then wizard name.
            var wizards = Wizard.Wizards.Value;
            List<string> result = new List<string>();

            var query = wizards.OrderByDescending(w => w.Creator)
            .ThenByDescending(w => w.Name)
            .GroupBy(w => w.Creator, v => v)
            .Select(v => v);

            foreach (var group in query)
            {
                foreach (var wizard in group.ToList())
                {
                    result.Add(wizard.Name);
                }
            }

            return result;

        }
    }
}
