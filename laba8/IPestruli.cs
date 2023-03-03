class IPestruli : IDolphinFamily
{
    protected string kind;
    internal string Kind
    {
        set { kind = value; }
        get { return kind; }
    }
    protected IPestruli()
    {
        Genus = "пёстрые дельфины";
        Kind = "unknown";
    }
}