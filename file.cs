// See https://aka.ms/new-console-template for more information



 DateTime v1 = DateTime.Now;
 System.Console.WriteLine( v1.DayOfWeek ); // printing the date "sunday or Thuesday"

System.Console.WriteLine( v1.DayOfYear ); // 149 , 289

System.Console.WriteLine(  v1.IsDaylightSavingTime() ); // i dont get this information 

System.Console.WriteLine(  v1.Kind );  // local or utc


// time convertor

System.Console.WriteLine( v1.ToUniversalTime() );

v1 = v1.AddHours(1); // positive 
System.Console.WriteLine( v1);

System.Console.WriteLine( v1.AddHours(-5) ); // nnegative



// timeSpan 
// time stamp not contain time in a day it's containing defferent time points 





TimeSpan ts = TimeSpan.Parse("4:15:30.12345"); // 4 hours 15 minutes 30 secound 12345 milisecound 
// TimeSpan ts = TimeSpan.Parse("5:4:15:30.12345"); // now we add 5 days 

System.Console.WriteLine( ts.Days ); // how many days in given time stamp
System.Console.WriteLine(  ts.Minutes ); // number of minutes 
System.Console.WriteLine(  ts.TotalMinutes ); // totoal number of minutes 