
class WaterMammals : WaterAnimals
{
    protected string family;
    public string Family
    {
        set { family = value; }
        get { return family; }
    }
    internal WaterMammals() : base()
    {
        Groupp = "млекопитающее";
        Family = "unknown";
    }
    internal WaterMammals(string family) : base()
    {
        Groupp = "млекопитающее";
        Family = family;
    }
    override internal bool Kormlenie()
        {
            Sytost = true;
            return Sytost;
        }
    override internal string AllInfo()
    {
        Golod = "";
        if (Sytost is false)
            Golod = "голодный";
        else Golod = "сытый";
        return "Группа животных: " + Groupp +  ", семейство животных: " + Family + ", сытость: " + Golod;
    }
}