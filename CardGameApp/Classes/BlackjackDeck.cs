// Today we will make a simple Mini Project - Card Game application in C#.






public class BlackjackDeck : DeckOfCards
{
    public BlackjackDeck() // Constructor for BlackjackDeck class
    {
        CreateDeck();
        ShuffleDeck();
    }
    public override List<PlayingCard> DealCard()
    {
        List<PlayingCard> output = new List<PlayingCard>();
        for (int i = 0; i < 2; i++)
        {
            output.Add(DrawOneCard());
        }
        return output;
    }
    public PlayingCard RequestCard()
    {
        return DrawOneCard();
    }
}
