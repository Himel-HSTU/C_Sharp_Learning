// Today we will make a simple Mini Project - Card Game application in C#.






public abstract class DeckOfCards
{
    protected List<PlayingCard> FullDeckOfCards = new List<PlayingCard>();
    protected List<PlayingCard> DrawPile = new List<PlayingCard>();
    protected List<PlayingCard> DiscardPile = new List<PlayingCard>(); 
    protected void CreateDeck()
    {
        FullDeckOfCards.Clear();
         for (int suit = 0; suit < 4; suit++)
        {
            for (int val = 0; val < 13; val++)
            {
                FullDeckOfCards.Add(new PlayingCard {Suit = (CardSuit)suit,Value = (CardValue)val });

            }
        }
    }
    public virtual void ShuffleDeck()
    { // The shuffle might need to be override in some cases
        var random = new Random();
        DrawPile = FullDeckOfCards.OrderBy(x=>random.Next()).ToList(); // For now, lets remeber this line
        // What we are doing here is we are taking the FullDeckOfCards and shuffling it randomly and storing it in DrawPile

    }
    //public int GetOrder(PlayingCard card) // Shortcut Backend of OrderBy or Shuffling Method ---- Lambda Expression
    //{
    //    if (card.Suit == CardSuit.Clubs)
    //    {
    //        return 1;
    //    }
    //    else return 0;
    //}
    public abstract List<PlayingCard> DealCard();

    protected virtual PlayingCard DrawOneCard() {  // this method might need to be override in some cases
       PlayingCard output = DrawPile.Take(1).First();
       DrawPile.Remove(output);
        return output; // this will return the first card from the DrawPile and remove it from the DrawPile
    }
}
