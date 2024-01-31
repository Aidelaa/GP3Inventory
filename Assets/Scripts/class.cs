
[System.Serializable]
public struct Items
{
    public string Name;
    public int ID;
    public int Quantity;

    public Items(string name, int id, int quantity)
    {
        Name= name;
        ID= id;
        Quantity= quantity;
    }
}
