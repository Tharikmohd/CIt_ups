using System;
using System.Net.WebSockets;

namespace Eventhandling
{
    public delegate void Buttonclick();

    class Button
    {
        public event Buttonclick? Click;

        public void Clickbutton()
        {
            Console.WriteLine("Button Clicked");

            Click?.Invoke();
        } 

    }
    class EventDemo
    {
        public static void Showmessage()
        {
            Console.WriteLine("Button clicked for demo");
        }

        public static void Popup()
        {
            Console.WriteLine("Welcome");
        }

        public static void Main()
        {
            Button btn = new Button();

            btn.Click += Showmessage;
            btn.Click += Popup;

            btn.Clickbutton();
        }
    }
}