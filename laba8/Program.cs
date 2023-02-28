WaterAnimals[] oceanarray =
{
    new CommersonDolphin("Роро"),
    new BullShark("Рири"),
    new BullShark("Рината")
};

for (int i = 0; i < oceanarray.Length; i++)
{
    if (i % 2 == 0) oceanarray[i].Kormlenie();
    Console.WriteLine(oceanarray[i].AllInfo());
}