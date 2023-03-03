public interface IWaterAnimals
{
    string Golod
    { get; set; }
    string Groupp
    { get; set; }
    bool Sytost
    { get; set; }
    abstract public void Kormlenie();
    virtual internal string AllInfo()
    {
        return "буль буль";
    }
}