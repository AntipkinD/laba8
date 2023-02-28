class WaterFishes : WaterAnimals
{
    protected string family;
    public string Family
    {
        set { family = value; }
        get { return family; }
    }
    internal WaterFishes() : base()
    {
        Groupp = "рвба";
        Family = "unknown";
    }
    internal WaterFishes(string family, bool sytost) : base()
    {
        Groupp = "рвба";
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
        return "Группа животных: " + Groupp + ", семейство животных: " + Family + ", сытость: " + Golod;
    }
}