using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name please");
           public string name (Console.ReadLine());
            Console.WriteLine("type in your credit card number");
          private  int creditcard = Console.ReadLine();
          private  int pin = Console.ReadLine();
          private  int expiryDate = Console.ReadLine();
        }
    }
class CreditCard //Attributes and Properties 
{
    public string cardName;
    private int cardNo;
    private int pinNo;
    public int expiryDate;

    public string Creditcard { get; set; }
    public int CardNo {private get; set; }
    public int PinNo {private get; set; }
    public int { get; set; }
}

//Constructor 
public CreditCard (string _creditcard, int _cardNo, int _pinNo, int _expiryDate)
{
    CreditCard = _creditcard;
    CardNo = _cardNo;
    PinNo = _pinNo;






}
//set the info but not get the privates



      

}
//create instance
//display card name and expiry back to user
DateTime