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