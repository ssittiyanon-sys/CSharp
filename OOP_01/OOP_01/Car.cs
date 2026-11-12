using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_01
{
    internal class Car // internal ใช้งานได้เฉพาะภายใน Project (หรือ Assembly) เดียวกันเท่านั้น
    {
        // Member variable
        // private hides the variable from other classes
        private string _model = ""; 
        private string _brand = ""; // private ส่วนตัวสุดๆ ใช้งานได้ เฉพาะภายในคลาส (Class) เดียวกันเท่านั้น

        int lumen;

        // Property 
        // public string Model { get; set; } // public สาธารณะ ทุกคนบนโลกสามารถเรียกใช้งานได้

        // Property with lambda

        // Lamda Expression (=>) นิพจน์แลมป์ดา เมื่อคุณต้องการเอา Model มาใส่ตรงนี้ เราจะ set _model as value
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand; set => _brand = value; }

        // Define how the property is set (Mostly done in Main)


        // Custom Constructor
        public Car(string model, string brand) // PASS DATA TO
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the model {Model} been created!");

        }

    }
}
