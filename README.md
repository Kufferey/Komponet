# Komponet
A Componet system in C#. Made for the fun of it. Not Ment For Actual Use.

Its a .dotnet class library.

# Making A Komponet
Making a Komponet is easy (hopefully).

To start make a basic file lets call it "PersonKomp.cs":
```
using Komponets;

public class PersonKomp : Komponet
{
}
```

Cool, lets add some variables:
```
using Komponets;

public class PersonKomp : Komponet
{
    public string PersonName { get; set; }
    public int PersonAge { get; set; }

    public PersonKomp(string name, int age)
    {
        PersonName = name;
        PersonAge = age;
    }
}
```
