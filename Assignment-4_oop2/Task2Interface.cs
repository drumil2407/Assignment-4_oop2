using System;


namespace A4.Task2Interface
{
	
	interface ICarryPassengers
	{
		public string CarryPassengers();
	}
	class Ship
	{
		
		public double Displacement { get; }

		public Ship(double displacement)
		{
			Displacement = displacement;
		}
		public override string ToString()
		{
			return $"A ship that displaces {Math.Round(Displacement, 2)} tons of water";
		}

	}
	//inherut ship as well as interface IcarryPassengers
	class CruiseShip : Ship,ICarryPassengers
	{

		private int NumPassengers;

		public CruiseShip(double displacement, int numPassengers) : base(displacement)
        {
			this.NumPassengers = numPassengers;
		}
		public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {NumPassengers} passengers on a Caribbean Cruise";
		}
		public override string ToString() => CarryPassengers();

	}

	class BigRig
	{
		public int NumTires;

		public BigRig(int numTires)
		{
			NumTires = numTires;
		}
		public override string ToString() => $"A vehicle with {NumTires} tires"; 
	}

	//inherit BigRig as well as IcarryPassengers
	class TourBus :BigRig, ICarryPassengers
	{
	
		private int numPassengers;
		public TourBus(int numTires, int numPassengers):base(numTires)
		{
			this.numPassengers = numPassengers;
		}
		public  string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a cross country tour.";
		}

		public override string ToString() => CarryPassengers();
	}
}
