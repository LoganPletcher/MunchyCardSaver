public interface ICard// : ICardLogger
{
    string Name { get; set; }

    string Description { get; set; }



}


public interface ICardLogger
{
    string Info { get; set; }
}


public interface IMystery : ICard
{
    int Power { get; set; }
    MysteryType CardType { get; set; }
}

public interface ITreasure : ICard
{
    int Gold { get; set; }
    TreasureType CardType { get; set; }
}
