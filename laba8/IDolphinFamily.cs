class IDolphinFamily : IWaterMammals
{
    protected string genus;
    internal string Genus
    {
        set { genus = value; }
        get { return genus; }
    }
    protected IDolphinFamily() : base()
    {
        Family = "дельфиновые";
        Genus = "unknown";
    }
}