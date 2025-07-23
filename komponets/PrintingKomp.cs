using Komponets;

public class PrintingKomp : Komponet
{
    public string PrintText { get; set; } = "";

    public override void KomponetAdded()
    {
        PrintTheText();
    }

    public override void KomponetRemoved()
    {
        Console.WriteLine("Print Componet Removed");
    }

    public void PrintTheText()
    {
        Console.WriteLine(PrintText);
    }
}