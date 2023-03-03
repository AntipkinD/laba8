public class IWaterMammals : /*WaterAnimals,*/ IWaterAnimals
{
    protected string family;
    protected string groupp;
    protected bool sytost;
    protected string golod;
    public string Groupp
    {
        set { groupp = value; }
        get { return groupp; }
    }
    public bool Sytost
    {
        set { sytost = value; }
        get { return sytost; }
    }
    public string Golod
    {
        set { golod = value; }
        get { return golod; }
    }
    public string Family
    {
        set { family = value; }
        get { return family; }
    }
    protected IWaterMammals()
    {
        Groupp = "млекопитающие";
        Sytost = false;
        Family = "unknown";
    }
    virtual public void Kormlenie()
    {
        Sytost = true;
    }
    virtual internal string AllInfo()
    {
        if (Sytost == false)
            Golod = "голоден(а)";
        else Golod = "сыт(а)";
        return $"{Groupp}, {Sytost}, {Family}";
    }
}