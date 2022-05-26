// See https://aka.ms/new-console-template for more information


using System;

DateTime sample = new DateTime();
System.Console.WriteLine(sample);


DateTime currentTime = DateTime.Now;
System.Console.WriteLine(currentTime);


DateTime universalTime = DateTime.UtcNow; // time zone information not available with the information
System.Console.WriteLine(universalTime);

// try to capture log time base on utc 


DateTime min = DateTime.MinValue;
DateTime max = DateTime.MaxValue;

System.Console.WriteLine($"minvalue => {min} maxvalue => {max}");


DateTime? nullvalue = null;

// today 
DateTime todoy = DateTime.Today; // 10/22/2021 12:00:00 AM  <------- last part special (DATE AND TIME IS ZERO)

System.Console.WriteLine(todoy.Ticks); // 1/10 milion * 1 secound 




 ///////// props ////

 DateTime v1 = DateTime.Now;
 System.Console.WriteLine( v1.DayOfWeek ); // printing the date "sunday or Thuesday"

System.Console.WriteLine( v1.DayOfYear ); // 149 , 289

System.Console.WriteLine(  v1.IsDaylightSavingTime() ); // i dont get this information 

System.Console.WriteLine(  v1.Kind );  // local or utc

