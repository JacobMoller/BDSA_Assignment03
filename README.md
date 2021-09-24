# Assignment #3

## C&#35;

Clone this repository and bring the code pieces you need into your BDSA Assignments GitHub repository.

### Extension Methods

Consider the two methods you implemented last week:

```csharp
IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)

IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
```

Given the following collections in scope:

```csharp
IEnumerable<int>[] xs;

int[] ys;
```

Solve the following questions with extension methods (one-liners):

1. Flatten the numbers in `xs`.
2. Select numbers in `ys` which are divisible by `7` and greater than `42`.
3. Select numbers in `ys` which are *leap years*.

Write the answers in the ANSWERS.md file.

Implement and test the following extension methods:

1. A method `IsSecure` which extends `Uri` and returns true if the `Uri` is using *Secure Hypertext Transfer Protocol*.
1. A method `WordCount` which extends `string` and returns the number of words in the string. Note a word can only contain *unicode letters* (no numbers or symbols).

Use the supplied `Extensions.cs` and `ExtensionsTests.cs` files.

### Delegates / Anonymous methods

Implement the following anonymous functions using the built-in delegates and lambda expressions:

1. A method which takes a string and prints the content in reverse order (by character)
1. A method which takes two decimals and returns the product
1. A method which takes a whole number and a string and returns `true` if they are numerically equal. Note that the string `"  0042"` should return true if the number is `42`

Write the answers in the ANSWERS.md file.

You probably want to implement a set of tests to validate the methods.

Use the supplied `DelegatesTests.cs` file.

### LINQ

Prerequisite: Extend the `Wizards.csv` file with at least 10 wizard of your choosing to enable the queries above.
Examine the `Wizard` class and its corresponding unit test class.

Then, given the `Wizard` class:

```csharp
public class Wizard
{
    public string Name { get; set; }

    // Book or film or...
    public string Medium { get; set; }

    public int? Year { get; set; }

    public string Creator { get; set; }

    public static Lazy<IReadOnlyCollection<Wizard>> Wizards { get; } = new Lazy<IReadOnlyCollection<Wizard>>(() =>
    {
        var csv = File.OpenText("../../../../Wizards.csv");
        using (var reader = new CsvReader(csv))
        {
            reader.Configuration.Delimiter = ",";
            return reader.GetRecords<Wizard>().ToList().AsReadOnly();
        }
    });
}
```

Use the supplied `Queries.cs` and corresponding tests class to implement and test the following queries using LINQ:
(You need to wrap the queries in suitable methods for testing)

1. Wizards invented by *Rowling*. Only return the names.
1. The year the first *sith lord* was introduced. Let's define a *sith lord* to be one named Darth *something*.
1. Unique list of wizards from the *Harry Potter* books - only return name and year (as a value tuple).
1. List of wizard names grouped by creator in reverse order by creator name and then wizard name.

Each method *must* be implemented twice - once using only *extension methods* and once using as much *LINQ* as possible.









## Software Engineering

### Exercise 1

What is the difference between a scenario and a use case? When do you use each construct?



### Exercise 2
Draw the visual part of a use case diagram for a ticket distributor for a train system. The system includes two actors: a traveler, who purchases different types of tickets, and a central computer system, which maintains a reference database for the tariff. Use cases should include: __BuyOneWayTicket__, __BuyWeeklyCard__, __BuyMonthlyCard__, __UpdateTariff__. Also include the following exceptional cases: __Time-Out__ (i.e., traveler took too long to insert the right amount), __TransactionAborted__ (i.e., traveler selected the cancel button without completing the transaction), __DistributorOutOfChange__, and __DistributorOutOfPaper__.
Write the complete textual part of the __BuyOneWayTicket__ use case; this will require to consider also the exceptional cases.


### Exercise 3
Draw a sequence diagram for the warehouseOnFire scenario of Figure 2-21. Include the objects __bob__, __alice__, __john__, __FRIEND__, and instances of other classes you may need. Draw only the first five message sends.



### Exercise 4

Research what a Kanban board is.  Possibly starting from [here](https://www.atlassian.com/agile/kanban/boards), acquire sufficient application domain knowledge to write two as-is scenarios that represent the main usage of a physical Kanban board within a software engineering team.  Note: make sure to cite your references in the submission document.  

### Exercise 5

As a design activity (i.e., before writing the code): draw a class diagram representing your design of the entities for the C# part.  The purpose of the diagram should be to `sketch` the main relationships between the entities and their multiplicity.  To challenge yourselves, consider that often teams use the boards to also highlight task allocation (i.e., who is responsible for/will complete/has taken a card) and that nowadays pair programming or other group practices are used to implement code.  How would you model this feature?


### Exercise 6

1. The acronym FURPS+ stands for: F_____________; U_____________; R_____________; P_____________; S_____________; +_____________.
1. The requirements engineering process is an iterative process that includes requirements ______________, ______________, and ______________.
1. Software engineering is a collection of ______________, ______________, and ______________ that help with the production of a ______________ software system developed ______________ before a ______________ while change occurs.
1. Requirements need to be complete, ______________, ______________, and ______________.
1. Important properties of requirements are realism, ______________, and ______________.
1. The output of the ______________ activity is the ______________, which include both the non-functional requirements and the functional model.


### Exercise 7

1. What level of details should UML models have?
2. What is the difference between structure diagrams and behavior diagrams in UML?  Provide two examples per category.


### Exercise 8

Consider a file system with a graphical user interface, such as Macintosh’s Finder, Microsoft’s Windows Explorer, or Linux’s KDE. The following objects were identified from a use case describing how to copy a file from a floppy disk to a hard disk: File, Icon, TrashCan, Folder, Disk, Pointer. Specify which are entity objects, which are boundary objects, and which are control (interactor) objects.

### Exercise 9

Assuming the same file system as before, consider a scenario consisting of selecting a file on a floppy, dragging it to Folder and releasing the mouse. Identify and define one control (interactor) object associated with this scenario.

### Exercise 10

Arrange the objects listed in Exercises SE.8-9 horizontally on a sequence diagram, the boundary objects to the left, then the control (interactor) object you identified, and finally, the entity objects. Draw the sequence of interactions resulting from dropping the file into a folder. For now, ignore the exceptional cases.

### Exercise 11

From the sequence diagram Figure 2-34, draw the corresponding class diagram. Hint: Start with the participating objects in the sequence diagram.




## Submitting the assignment

To submit the assignment you need to create a .pdf document using LaTeX containing the answers to the questions and a link to a public repository containing your fork of the completed code.

Members of the triplets should submit the same PDF file to pass the assignments.  Make sure all group names and ID are clearly marked on the front page. 



