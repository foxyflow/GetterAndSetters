using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Goal: Set the info but not get the privates:
namespace GetSet2019
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.ReadKey();

            

            Console.WriteLine("Enter your public name on card");
            string cardName = Console.ReadLine();
            Console.WriteLine("Enter your private account number");
            int cardNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your private pin number");
            int pinNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your public expiry date");
            string expiryDate = Console.ReadLine();
            Console.Clear();

            CreditCard cc = new CreditCard(cardName, cardNo, pinNo, expiryDate);
            /*
            Console.WriteLine($"Name on card {cc.CardName}");
           // Console.WriteLine($"Private account Number:{cc.CardNo}");
           // Console.WriteLine($"private pin number {cc.PinNo}");
            Console.WriteLine($"public expiry date {cc.ExpiryDate}");
            */
            Console.WriteLine(cc.DisplayPrivate());

            Console.WriteLine("Application finished");
            Console.ReadLine();           
        }
    }
    class CreditCard
    {

        //Attributes 
        private string cardName;
        private string expiryDate;
        private int cardNo;
        private int pinNo;



        public string CardName //Properties (Getters and Setters)
        {
            get { return cardName; }
            set { cardName = value; }
        }
        public int CardNo
        {
            private get { return cardNo; }
            set { cardNo = value; }
        }
        public int PinNo
        {
            private get { return pinNo; }
            set { pinNo = value; }
        }
        public string ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        //Constructor
        public CreditCard(string _cardName, int _cardNo, int _pinNo, string _expiryDate)

        {
            CardName = _cardName;
            CardNo = _cardNo;
            PinNo = _pinNo;
            ExpiryDate = _expiryDate;
            Console.WriteLine("New Credit Card Object Created");          
        }
        public string DisplayPrivate()
        {
            return $"Private CardNumber: {CardNo}\n  Private PinNumber: {PinNo}\n Public CardName {CardName}\n Public expiry date {ExpiryDate}";


        }
        public CreditCard()
        {
            Console.WriteLine("New Credit Card Object Created");
        }
    }
}


        












      

//Notes:
//create instance
//display card name and expiry back to user
//DateTime -- extra