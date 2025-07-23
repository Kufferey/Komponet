# Komponet
A Componet system in C#. Made for the fun of it. Not Ment For Actual Use.

Its a Dotnet class library.

# Making A Komponet
Making a Komponet is easy (hopefully).

To start make a basic file lets call it "PersonKomp.cs":
```csharp
using Komponets;

public class PersonKomp : Komponet
{
}
```
Cool, lets add some variables:
```csharp
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
Okay, we got a basic person class Konponet.
Two `override` functions you can do it:
`public override void KomponetAdded()` and `public override void KomponetRemoved()`.
The names are self explanatory. But we can add this to our custom Komponet:
```csharp
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

    public override void KomponetAdded()
    {
        base.KomponetAdded();
    }

    public override void KomponetRemoved()
    {
        base.KomponetRemoved();
    }
}
```
