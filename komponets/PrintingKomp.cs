using Komponets;

public class PrintingKomp : Komponet
{
    public string PrintText { get; set; } = "";
    
    public override void KomponetAdded()
    {
        Console.WriteLine(PrintText);
    }

    public override void KomponetRemoved()
    {
        Console.WriteLine("Print Componet Removed");
    }
}