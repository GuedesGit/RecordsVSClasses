// 🧱 CLASS (mutable, reference equality)
public class WizardClass
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }

    public override string ToString() => $"WizardClass {{ Name = {Name}, PowerLevel = {PowerLevel} }}";
}

// 🧾 RECORD (immutable, value equality)
public record WizardRecord(string Name, int PowerLevel);


class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // For emoji support

        Console.WriteLine("🧪 CLASS DEMO:");
        var wizardClass = new WizardClass { Name = "Gandalf", PowerLevel = 9000 };
        Console.WriteLine(wizardClass); // prints class info
        wizardClass.PowerLevel = 10000;
        Console.WriteLine($"🔁 Updated power: {wizardClass.PowerLevel}");

        var anotherWizardClass = new WizardClass { Name = "Gandalf", PowerLevel = 10000 };
        Console.WriteLine($"🤔 Are they equal? {wizardClass.Equals(anotherWizardClass)}"); // false (reference)

        Console.WriteLine("\n🧪 RECORD DEMO:");
        var wizardRecord = new WizardRecord("Gandalf", 9000);
        //wizardRecord.PowerLevel = 10000; // Error: Cannot assign to 'PowerLevel' because it is read-only
        Console.WriteLine(wizardRecord); // prints record info

        var strongerWizard = wizardRecord with { PowerLevel = 10000 };
        Console.WriteLine($"🧙 Stronger wizard: {strongerWizard}");

        var anotherWizardRecord = new WizardRecord("Gandalf", 9000);
        Console.WriteLine($"🤝 Are they equal? {wizardRecord.Equals(anotherWizardRecord)}"); // true (value)
    }
}