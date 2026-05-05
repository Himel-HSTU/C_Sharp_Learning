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
