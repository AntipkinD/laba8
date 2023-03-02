WaterAnimals[] oceanarray =
{
    new CommersonDolphin("Роро", 7),
    new BullShark("Рири", 5),
    new BullShark("Рината", 6)
};

for (int i = 0; i < oceanarray.Length; i++)
{
    if (i % 2 == 0) oceanarray[i].Kormlenie();
    Console.WriteLine(oceanarray[i].AllInfo());
}