// Today we will make a simple Mini Project - Card Game application in C#.






Console.WriteLine("Welcome to the Card Game Application!");
Console.WriteLine();
Console.WriteLine("Here's Your Five Poker Card -");
int cardNumber = 1;
PokerDeck pokerDeck = new PokerDeck();
var Hand = pokerDeck.DealCard();

foreach (var card in Hand) // Each Time we will get 5 different cards from the deck and display them on the console
{
    Console.WriteLine($"Card {cardNumber}: {card.Value} of {card.Suit}");
    cardNumber++;
}
Console.WriteLine();
Console.WriteLine("Here's Your Two Blackjack Cards -");
int cardNumber2 = 1;
BlackjackDeck blackDeck = new BlackjackDeck();
var Hand2 = blackDeck.DealCard();

foreach (var card in Hand2) // Each Time we will get 5 different cards from the deck and display them on the console
{
    Console.WriteLine($"Card {cardNumber2}: {card.Value} of {card.Suit}");
    cardNumber++;
}




Console.ReadLine();

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
public class PlayingCard 
{
    public CardSuit Suit { get; set; }

    public CardValue Value { get; set; }  
}

public enum CardValue // Enum to represent the values of a standard deck of playing cards
{ 
    Ace=1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

public enum CardSuit // Enum to represent the four suits of a standard deck of playing cards
                     // This works like - 1 for hearts 2 for clubs 3 for diamonds and 4 for spades 
{
    Hearts,
    Clubs,
    Diamonds,
    Spades
}