using HotChocolateAutoRegistrationTest.Schema.Types;

namespace HotChocolateAutoRegistrationTest.Schema.Queries;

[QueryType]
public static class PersonQuery
{
    public static IEnumerable<Person> GetPersons()
    {
        return new List<Person>
        {
            new Person
            {
                FisrtName = "Ozzy",
                LastName = "Osbourne"
            },
            new Person
            {
                FisrtName = "Johnny",
                LastName = "Ramone"
            },
            new Person
            {
                FisrtName = "Lemmy",
                LastName = "Kilmister"
            }
        };
    }
}
