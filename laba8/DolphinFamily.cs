class DolphinFamily : WaterMammals
{
    protected string genus;
    public string Genus
    {
        set { genus = value; }
        get { return genus; }
    }
    internal DolphinFamily() : base()
    {
        Family = "дельфиновые";
        Genus = "unknown";
    }
    internal DolphinFamily(string genus) : base()
    {
        Family = "дельфиновые";
        Genus = genus;
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