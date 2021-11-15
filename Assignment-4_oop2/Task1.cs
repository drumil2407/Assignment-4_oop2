using System;
using System.Collections.Generic;

namespace A4
{
	enum Values
	{
		Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
	}

	enum Suits
	{
		Clubs, Diamonds, Hearts, Spades
	}

	class Card
	{
		public Values Value { get; private set; }
		public Suits Suit { get; private set; }

		public Card(Values value, Suits suit)
		{
			Value = value;
			Suit = suit;
		}

		public override string ToString()
		{
			return $"{Value} of {Suit}";
		}
	}

	class CardComparerByValue : IComparer<Card>
	{
		/// <summary>
		/// Value order is intuitive going in ascending order from A,2,...,Q,K
		/// Suit should be ordered as follows: Clubs, Diamonds, Hearts, Spades (same as enum ordering)
		/// </summary>
		public int Compare(Card a, Card b)
		{
			if (a.Value == b.Value)
			{
				return (int)a.Value;
			}
			else if (a.Value > b.Value)
			{
				return (int)b.Value;
			}

			else if (a.Suit == b.Suit)
			{
				return (int)a.Suit;
			}
			else if (a.Suit > b.Suit)
			{
				return (int)b.Suit;
			}
			else
			{
				return 0;
			}
		}
	}
}
