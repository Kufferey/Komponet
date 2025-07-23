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
Cool, lets add some variables and stuff:
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
Okay, we are getting somewhere (Kinda).
### Making A Komponet | 02
Now we are going to focus on the `override` functions that was mentioned ealier.
Lets make it where if the Komponet gets added/removed it prints some text:
```csharp
public override void KomponetAdded()
{
    Console.WriteLine($"{PersonName} Was Born at age: {PersonAge}!");
}

public override void KomponetRemoved()
{
    Console.WriteLine($"{PersonName} died at age: {PersonAge}.");
}
```
Here is the full file:
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
        Console.WriteLine($"{PersonName} Was Born at age: {PersonAge}!");
    }

    public override void KomponetRemoved()
    {
        Console.WriteLine($"{PersonName} died at age: {PersonAge}.");
    }
}
```
