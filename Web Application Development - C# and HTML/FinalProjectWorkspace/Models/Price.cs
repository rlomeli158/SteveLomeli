using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
	public class Price
	{
		/*
		//Constants for tax_rate of 8.75% 
		const Decimal SALES_TAX_RATE = 0.0875m;

		//Constants for Matinee - all movies that start before 12:00 noon on weekdays (MTWThF)
		const Decimal MATINEE_PRICE = 5.00m;

		//Constants for Discount Tuesday - all movies that start on or after 12:00 noon and before 5:00pm on Tuesdays
		const Decimal DISCOUNTTUESDAY_PRICE = 8.00m;

		//Constants for Weekday - shows that start at 12:00 noon or later on weekdays (MWTh – but not Tuesdays and Fridays)
		const Decimal WEEKDAYREGULAR_PRICE = 10.00m;

		//Constants for Weekend - all shows on weekends (Friday after 12:00 noon and all day Saturday and Sunday)
		const Decimal WEEKENDREGULAR_PRICE = 12.00m;
		*/


		public Int32 PriceID { get; set; }

		[Display(Name = "Price Name")]
		public String PriceName { get; set; }

		[Display(Name = "Price Amount")]
		[DisplayFormat(DataFormatString = "{0:C}")]
		public Decimal PriceAmount { get; set; }
		

	}
}
