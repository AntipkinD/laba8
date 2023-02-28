class CommersonDolphin : Pestruli
{
    protected string name;
    protected int yo;
    internal string Name
    {
        set { name = value; }
        get { return name; }
    }
    protected const string nutrition = "хищник";
    protected const int lifeexpectancy = 10;
    internal CommersonDolphin() : base()
    {
        Kind = "дельфин Коммерсона";
        Name = "NoName";
    }
    internal CommersonDolphin(string name) : base()
    {
        Kind = "дельфин Коммерсона";
        Name = name;
    }
    override internal void Kormlenie()
    {
        Sytost = true;
        Console.WriteLine($"{Kind} {Name} покормлен(а)!");
    }
    override internal string AllInfo()
    {
        if (Sytost is false)
            Golod = "голоден(а)";
        else Golod = "сыт(а)";
        return $"имя: {Name}, \n" +
            $"группа животных: {Groupp}, \n" +
            $"семейство животных: {Family}, \n" +
            $"род животных: {Genus}, \n" +
            $"вид животных: {Kind}, \n" +
            $"тип питания: {nutrition}, \n" +
            $"сытость: {Golod}, \n" +
            $"продолжительность жизни: {lifeexpectancy} лет \n" +
            $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
    }
}
