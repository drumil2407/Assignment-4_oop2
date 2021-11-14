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
			a= new Card(Values.Ace, Suits.Clubs);
			a = new Card(Values.Ace, Suits.Diamonds);
			a = new Card(Values.Ace, Suits.Hearts);
			a = new Card(Values.Ace, Suits.Spades);
			a = new Card(Values.Two, Suits.Clubs);
			a = new Card(Values.Two, Suits.Diamonds);
			a = new Card(Values.Two, Suits.Hearts);
			a = new Card(Values.Two, Suits.Spades);
			a = new Card(Values.Three, Suits.Clubs);
			a = new Card(Values.Three, Suits.Diamonds);
			a = new Card(Values.Three, Suits.Hearts);
			a = new Card(Values.Three, Suits.Spades);
			a = new Card(Values.Four, Suits.Clubs);
			a = new Card(Values.Four, Suits.Diamonds);
			a = new Card(Values.Four, Suits.Hearts);
			a = new Card(Values.Four, Suits.Spades);
			a = new Card(Values.Five, Suits.Clubs);
			a = new Card(Values.Five, Suits.Diamonds);
			a = new Card(Values.Five, Suits.Hearts);
			a = new Card(Values.Five, Suits.Spades);
			a = new Card(Values.Six, Suits.Clubs);
			a = new Card(Values.Six, Suits.Diamonds);
			a = new Card(Values.Six, Suits.Hearts);
			a = new Card(Values.Six, Suits.Spades);
			a = new Card(Values.Seven, Suits.Clubs);
			a = new Card(Values.Seven, Suits.Diamonds);
			a = new Card(Values.Seven, Suits.Hearts);
			a = new Card(Values.Seven, Suits.Spades);
			a = new Card(Values.Eight, Suits.Clubs);
			a = new Card(Values.Eight, Suits.Diamonds);
			a = new Card(Values.Eight, Suits.Hearts);
			a = new Card(Values.Eight, Suits.Spades);
			a = new Card(Values.Nine, Suits.Clubs);
			a = new Card(Values.Nine, Suits.Diamonds);
			a = new Card(Values.Nine, Suits.Hearts);
			a = new Card(Values.Nine, Suits.Spades);
			a = new Card(Values.Ten, Suits.Clubs);
			a = new Card(Values.Ten, Suits.Diamonds);
			a = new Card(Values.Ten, Suits.Hearts);
			a = new Card(Values.Ten, Suits.Spades);
			a = new Card(Values.Jack, Suits.Clubs);
			a = new Card(Values.Jack, Suits.Diamonds);
			a = new Card(Values.Jack, Suits.Hearts);
			a = new Card(Values.Jack, Suits.Spades);
			a = new Card(Values.Queen, Suits.Clubs);
			a = new Card(Values.Queen, Suits.Diamonds);
			a = new Card(Values.Queen, Suits.Hearts);
			a = new Card(Values.Queen, Suits.Spades);
			a = new Card(Values.King, Suits.Clubs);
			a = new Card(Values.King, Suits.Diamonds);
			a = new Card(Values.King, Suits.Hearts);
			a = new Card(Values.King, Suits.Spades);


			return (int)a.Value;
			//int value = 0;
			//switch (value)
			//{
			//	case 1:
			//		Values Aces = Values.Ace;
			//		return (int)Aces;
			//	case 2:
			//		Values Two = Values.Two;
			//		return (int)Two;
			//	case 3:
			//		Values Three = Values.Three;
			//		return (int)Three;
			//	case 4:
			//		Values Four = Values.Four;
			//		return (int)Four;
			//	case 5:
			//		Values Five = Values.Five;
			//		return (int)Five;
			//	case 6:
			//		Values Six = Values.Six;
			//		return (int)Six;
			//	case 7:
			//		Values Seven = Values.Seven;
			//		return (int)Seven;
			//	case 8:
			//		Values Eight = Values.Two;
			//		return (int)Eight;
			//	case 9:
			//		Values Nine = Values.Nine;
			//		return (int)Nine;
			//	case 10:
			//		Values Ten = Values.Ten;
			//		return (int)Ten;
			//	case 11:
			//		Values Jack = Values.Jack;
			//		return (int)Jack;
			//	case 12:
			//		Values Queen = Values.Queen;
			//		return (int)Queen;
			//	case 13:
			//		Values King = Values.King;
			//		return (int)King;
			//	default:

			//		return 0;
			//}


		}
	}
}
