abstract class WaterAnimals
{
    //string name = "unknown";
    //string kind = "unknown";
    //string genus = "unknown";
    //string family = "unknown";
    protected string golod;
    protected string groupp;
    protected bool sytost;
    //string nutrition = "unknownядное";
    //int lifeexpectancy = 0;
    public string Golod 
    {
        set { golod = value; }
        get { return golod; } 
    }
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
    internal WaterAnimals()
    {
        Groupp = "unknown";
        Sytost = false;
    }
    abstract internal bool Kormlenie();
    virtual internal string AllInfo()
    {
        if (Sytost is false)
        Golod = "голодный";
        else Golod = "сытый";
        return Groupp + ", " + Golod;
    }
}