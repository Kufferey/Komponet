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

    virtual public void KomponetAdded()
    {

    }

    virtual public void KomponetRemoved()
    {

    }

    /// <summary>
    /// Adds a Komponet.
    /// </summary>
    /// <param name="komponet">The Komponet to add.</param>
    virtual public void AddKomponet(Komponet komponet)
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
    /// <param name="komponet">The Komponet to remove.</param>
    virtual public void RemoveKomponet(Komponet komponet)
    {
        if (Komponets.Contains(komponet))
        {
            Komponets.Remove(komponet);
            komponet.KomponetRemoved();
            Console.WriteLine("Komponet remove successfully.");
        }
        else
        {
            Console.WriteLine("Komponet could not be removed. (Komponet doesn't exist)");
        }
    }

    /// <summary>
    /// Returns a Komponet.
    /// </summary>
    /// <param name="komponet">The Komponet to return.</param>
    virtual public Komp? GetKomponet<Komp>() where Komp : Komponet
    {
        foreach (Komponet komponet in Komponets)
        {
            if (komponet is Komp)
                return (Komp)komponet;
        }
        return null;
    }
}