using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personaplication
{
    // student periytyy person luokasta
    // student on aliluokka ja person yliluokka
    // student saa kaikki person luokan ominaisuudet riippuen suojista
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {

        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname, lastname, address)
        {
            StudentID = studentID;
        }
        public void StudentMethod()
        {
            Console.WriteLine("learning oop");
        }
        //ylikirjoitetaan person luokassa oleva tostring() metodi
        //yliluokasta palautuu nimet ja osoite. lisätään vielä opiskelijanumero
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}

