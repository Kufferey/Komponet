namespace Komponets;

/// <summary>
/// A base class for Komponet.
/// </summary>

public class Komponet
{
    /// <summary>
    /// A list of all the current Komponets.
    /// </summary>
    public List<Komponet> Komponets { get; set; } = [];

    public object? AttachedObject { get; set; }

    virtual public void KomponetAdded()
    {
        AttachedObject = this;
    }

    virtual public void KomponetRemoved()
    {

    }

    /// <summary>
    /// Adds a Komponet by creating a class. So, makes it easier to edit properties.
    /// </summary>
    /// <param name="komponet">The Komponet to add.</param>
    virtual public void AddKomponetAsClass(Komponet komponet)
    {
        if (!Komponets.Contains(komponet))
        {
            Komponets.Add(komponet);
            komponet.KomponetAdded();
            Console.WriteLine("Komponet added successfully.");
        }
        else
        {
            Console.WriteLine("Komponet could not be added. (Komponet already exist)");
        }
    }

    /// <summary>
    /// Remove a Komponet.
    /// </summary>
    virtual public void RemoveKomponet<Komp>() where Komp : Komponet
    {
        Komponet? komponetToRemove = GetKomponet<Komp>();
        if (komponetToRemove == null)
        {
            Console.WriteLine($"Komponet {komponetToRemove} cannot be removed. (Komponet doesn't exist)");
            return;
        }

        komponetToRemove.KomponetRemoved();
        Komponets.RemoveAll(theKomp => theKomp == komponetToRemove);
    }

    // virtual public void RemoveKomponet(Komponet komponet)
    // {
    //     if (Komponets.Contains(komponet))
    //     {
    //         Komponets.Remove(komponet);
    //         komponet.KomponetRemoved();
    //         Console.WriteLine("Komponet remove successfully.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Komponet could not be removed. (Komponet doesn't exist)");
    //     }
    // }

    /// <summary>
    /// Returns a Komponet.
    /// </summary>
    /// <param name="komponet">The Komponet to return.</param>
    virtual public Komp GetKomponet<Komp>() where Komp : Komponet => Komponets.FirstOrDefault(komponet => komponet is Komp) as Komp;
}