using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avmFunctionsLab.DateUtils
{
	public class HolidayObserver
	{
		// Fixed Holidays
		static readonly Dictionary<DateTime, string> fixedHolidays = new Dictionary<DateTime, string>
		{
				{ new DateTime(1,1,1), "Peace" },
				{ new DateTime(1,1,5), "Work Day" },
				{ new DateTime(1,4,7), "Independence Day" },
				{ new DateTime(1,2,11), "Deads" },
				{ new DateTime(1,25,12), "Christmas" },
		};

		// Moving Holidays
		static readonly Dictionary<DateTime, string> movingHolidays = new Dictionary<DateTime, string>
		{
				{ new DateTime(1,4,3), "Carnival" },
				{ new DateTime(1,5,3), "Carnival" },
				{ new DateTime(1,6,3), "Carnival" },
		};

		// Constructor
		public HolidayObserver()
		{

		}

		// Public Method
		public bool IsHoliday(DateTime date)
		{
			return (IsFixedHoliday(date) || IsMovingHoliday(date));
		}

		// Private Method to get if is a fixed holiday
		private bool IsFixedHoliday(DateTime date)
		{
			try
			{
				DateTime findingDate = new DateTime(1, date.Month, date.Day);

				var holiday = fixedHolidays.Where(x => x.Key == findingDate).FirstOrDefault();

				return (!string.IsNullOrEmpty(holiday.Value));
			}
			catch
			{
				return false;
			}
		}

		// Private method to get if is a moving holiday
		private bool IsMovingHoliday(DateTime date)
		{
			try
			{
				DateTime findingDate = new DateTime(1, date.Month, date.Day);

				var holiday = movingHolidays.Where(x => x.Key == findingDate).FirstOrDefault();

				return (!string.IsNullOrEmpty(holiday.Value));
			}
			catch
			{
				return false;
			}
		}
	}
}
