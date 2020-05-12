using System;
using System.Collections.Generic;

namespace blackjack.Models
{
  class Game
  {



    public List<Card> Cards { get; set; } = new List<Card>();

    public List<Card> PlayerCards { get; set; } = new List<Card>();

    public List<Card> CompCards { get; set; } = new List<Card>();

    public void addCard(Card x)
    {
      Cards.Add(x);
    }

    public void DealCards()
    {

      for (int i = 0; i < 2; i++)
      {

        Random rng = new Random();
        int index = rng.Next(Cards.Count);
        Card Dealt = Cards[index];
        PlayerCards.Add(Dealt);
        Cards.RemoveAt(index);
      }
      for (int i = 0; i < 2; i++)
      {

        Random rng = new Random();
        int index = rng.Next(Cards.Count);
        Card Dealt = Cards[index];
        CompCards.Add(Dealt);
        Cards.RemoveAt(index);
      }

    }
    public void PrintCards()
    {

      Console.WriteLine($"The Computer has {CompCards[0].Name}");
      int score = 0;

      for (int i = 0; i < PlayerCards.Count; i++)
      {
        score += PlayerCards[i].Value;
        Console.WriteLine($"You have {CompCards[0].Name}");
        Console.WriteLine($"Your total is {score}");
      }



    }
    public void Hit()
    {

      Random rng = new Random();
      int index = rng.Next(Cards.Count);
      Card Dealt = Cards[index];
      PlayerCards.Add(Dealt);
      Cards.RemoveAt(index);
      Validate();


    }

    public void Validate()
    {




    }
    public void Setup()
    {
      Card twos = new Card("2", 2);
      Card twoc = new Card("2", 2);
      Card twoh = new Card("2", 2);
      Card twod = new Card("2", 2);
      Card threes = new Card("3", 3);
      Card threec = new Card("3", 3);
      Card threeh = new Card("3", 3);
      Card threed = new Card("3", 3);
      Card fours = new Card("4", 4);
      Card fourd = new Card("4", 4);
      Card fourc = new Card("4", 4);
      Card fourh = new Card("4", 4);
      Card fives = new Card("5", 5);
      Card fiveh = new Card("5", 5);
      Card fived = new Card("5", 5);
      Card fivec = new Card("5", 5);
      Card sixs = new Card("6", 6);
      Card sixd = new Card("6", 6);
      Card sixh = new Card("6", 6);
      Card sixc = new Card("6", 6);
      Card sevens = new Card("7", 7);
      Card sevenh = new Card("7", 7);
      Card sevend = new Card("7", 7);
      Card sevenc = new Card("7", 7);
      Card eights = new Card("8", 8);
      Card eighth = new Card("8", 8);
      Card eightd = new Card("8", 8);
      Card eightc = new Card("8", 8);
      Card nines = new Card("9", 9);
      Card nineh = new Card("9", 9);
      Card nined = new Card("9", 9);
      Card ninec = new Card("9", 9);
      Card tens = new Card("10", 10);
      Card tenh = new Card("10", 10);
      Card tend = new Card("10", 10);
      Card tenc = new Card("10", 10);
      Card jacks = new Card("J", 10);
      Card jackh = new Card("J", 10);
      Card jackd = new Card("J", 10);
      Card jackc = new Card("J", 10);
      Card queens = new Card("Q", 10);
      Card queenh = new Card("Q", 10);
      Card queend = new Card("Q", 10);
      Card queenc = new Card("Q", 10);
      Card kings = new Card("K", 10);
      Card kingh = new Card("K", 10);
      Card kingd = new Card("K", 10);
      Card kingc = new Card("K", 10);
      Card aces = new Card("A", 1);
      Card aceh = new Card("A", 1);
      Card aced = new Card("A", 1);
      Card acec = new Card("A", 1);


    }
    public void Stay()
    {
      int score = 0;
      for (int i = 0; i < CompCards.Count; i++)
      {
        score += CompCards[i].Value;
      }
      if (score < 17)
      {
        Stay();
      }
      else if (score == 21)
      {
        PrintCards();
        System.Console.WriteLine("You Lose");
      }
      else
      {
        PrintCards();

      }
    }
  }
}