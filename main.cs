using System;

class Program {
  public static void Main (string[] args) {
    
    //(com >= $0–2999 - Poor                                            c) $3000–4999 - Average                              d) $5000–9999 - Good                                                               e) $10000–14999 - Excellent              f) $15000 and above – Outstanding


   Console.WriteLine("Enter the Saleperson's name:");
   string userName = Console.ReadLine();
   Console.WriteLine("Saleperson's name is: " + userName);

   Console.WriteLine("Enter amount sold:");

   double Sales = Convert.ToDouble(Console.ReadLine());


 double Sale = 200 + (0.09 * Sales); 

 Console.WriteLine("The sale commission for " + userName);

Console.WriteLine("is " + Sale );
 

if (Sale >= 0 && Sale <= 2999)
{
  Console.WriteLine("Performance is Poor");
}

if  (Sale >= 3000 && Sale <= 4999)
{
  Console.WriteLine("Performance is average ");
}

if (Sale >= 5000 && Sale <= 9999)
{
  Console.WriteLine("Performance is good");
}

if (Sale >= 10000 && Sale <= 14999)
{
  Console.WriteLine("Performance is excellent ");
}

if (Sale >= 15000)
{
  Console.WriteLine("Performance is outstanding");
}




 




  


  
 

 



 









  }
}