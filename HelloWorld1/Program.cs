using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine ("Hello World!");
            
            Message myMessage;
            myMessage = new Message("Hello World");
            myMessage.Print();
            Message[] sandesha = new Message[7];
            sandesha[0] = new Message("Oo....mahesh Dalle!");
            sandesha[1] = new Message("Ja, simran Ja, jee le apni zindagi");
            sandesha[2] = new Message("Sachin, kya hai, Lappu sa to hai");
            sandesha[3] = new Message("Ek chutki sindoor ki keemat tum kya jano mukesh Babu");
            sandesha[4] = new Message("Ae Rupali, Ae Rupali!");
            sandesha[5] = new Message("Charas Gaanja mereko pyaara");
            sandesha[6] = new Message("Silly Name");
            Console.Write("Enter name: ");
            string name = Console.ReadLine().ToLower();

            if (name == "mahesh")
            {
                sandesha[0].Print();
            }
            else if (name == "simran")
            {
                sandesha[1].Print();
            }
            else if (name == "sachin")
            {
                sandesha[2].Print();
            }
            else if (name == "mukesh")
            {
                sandesha[3].Print();
            }
            else if (name == "rupali")
            {
                sandesha[4].Print();
            }
            else if (name == "carry")
            {
                sandesha[5].Print();
            }
            else
            {
                sandesha[6].Print();
            }
            
            Console.ReadLine();
        }
    }
}
