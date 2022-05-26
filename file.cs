// See https://aka.ms/new-console-template for more information



 DateTime v1 = DateTime.Now;
 System.Console.WriteLine( v1.DayOfWeek ); // printing the date "sunday or Thuesday"

System.Console.WriteLine( v1.DayOfYear ); // 149 , 289

System.Console.WriteLine(  v1.IsDaylightSavingTime() ); // i dont get this information 

System.Console.WriteLine(  v1.Kind );  // local or utc


// time convertor

System.Console.WriteLine( v1.ToUniversalTime() );

