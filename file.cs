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



// compare values 
System.Console.WriteLine($"{DateTime.Compare(v1,v2)}");
System.Console.WriteLine($"{DateTime.Compare(v2,v1)}");


/////////////////////////////////////
// printing
/////////////////////////////////////

System.Console.WriteLine($"short date {v1.ToString("d")}"); // 5/26/2022
System.Console.WriteLine($"long date {v1.ToString("D")}");  // Thursday, May 26, 2022
System.Console.WriteLine($"short time {v1.ToString("t")}"); // 12:46 PM
System.Console.WriteLine($"long time {v1.ToString("T")}");  // 12:46:43 PM


System.Console.WriteLine($"Round trip {v1.ToString("O")}"); // Round trip 2022-05-26T12:48:32.1044562+05:30


System.Console.WriteLine($"full short {v1.ToString("f")}");  // full short Thursday, May 26, 2022 12:52 PM
System.Console.WriteLine($"full long {v1.ToString("F")}");  // full long Thursday, May 26, 2022 12:52:08 PM
System.Console.WriteLine($"general short {v1.ToString("g")}"); // general short 5/26/2022 12:52 PM
System.Console.WriteLine($"general Long {v1.ToString("G")}"); // general Long 5/26/2022 12:52:08 PM


System.Console.WriteLine($"sortable {v1.ToString("s")}"); // sortable 2022-05-26T12:54:56
System.Console.WriteLine($"Universal Long {v1.ToString("U")}"); // Universal Long Thursday, May 26, 2022 7:24:56 AM



// custome printing 

System.Console.WriteLine($"custom {v1.ToString("MMM dd, yyyy  [hh:mm:tt] (zzz)")}"); //custom  May 26, 2022  [01:02:PM] (+05:30)
System.Console.WriteLine($"custom {v1.ToString("dd, yyyy  [HH:mm:tt] (zzz)")}"); // custom 26, 2022  [13:04:PM] (+05:30)