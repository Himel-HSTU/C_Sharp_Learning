// Today we will make a simple Mini Project - Card Game application in C#.






public class PokerDeck : DeckOfCards
{   
    public PokerDeck() // Constructor for PokerDeck class
    {
        CreateDeck();
        ShuffleDeck();
    }
    public override List<PlayingCard> DealCard()
    {
        List<PlayingCard> output = new List<PlayingCard>();
        for (int i = 0; i < 5; i++)
        {
            output.Add(DrawOneCard());
        }
        return output;
    }
    public List<PlayingCard> RequestCard(List<PlayingCard> cardsToDiscard)
    {
        List<PlayingCard> output = new List<PlayingCard>();
        foreach (var card in cardsToDiscard)
        {
            output.Add(DrawOneCard());
            DiscardPile.Add(card); // Add the discarded card to the Discard Pile
        }
        return output;  
    }
}
