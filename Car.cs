using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_raya_week_6
{
	class Car //2.1.1
	{

		private double current_car_speed;

		public double Current_Car_Speed
		{
			get { return current_car_speed; }
			set { current_car_speed = value; }
		}

		public void Speedup_By_one(Car c)
		{
			current_car_speed += 1;
		}

		public void Speeddown_By_one(Car c)
		{
			current_car_speed -= 1;
		}

		public double stop(Car c)
		{
			current_car_speed = 0;
			return current_car_speed;
		}


	}

	
}
