using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Practice
{
    //Create a 'Pen' class that has the following properties:
    class Pen
    {
        public int characterCount;
        //properties to be created is Brand, InkColor, InkLevel, MaxInk, HasLid
        public string Brand { get; set; } //Brand is a string cause it is just names
        public string InkColor { get; set; } //Colour is a string because it is just names


        //InkLevel (Percentage, must not accept values below 0 or above 100, throw an exception if an attempt to go lower than 0 is made, and clamp values higher than 100 to 100. Round inputs to two decimal places.) - make the setter private, and make the getter round the output to the nearest 5%
        //we have to specify a backing variable for InkLevel because we are doing some validation with the vale. 
        private double _inkLevel;
        public double InkLevel {
            get
            {
                return _inkLevel;
            } 
            private set 
            {
                //If the incoming value is under 0 or above 100
                if(value>100)
                {
                    _inkLevel = 100;
                } else
                {
                    if(value<0)
                    {
                        throw new Exception("Ink is too low");
                    }
                    _inkLevel = value;
                }
            } }
        public int MaxInk { get; set; }
        public bool HasLid { get; set; } //Boolean cause it is only yes/no cap.

        //create a constructor
        public Pen()
        {
            Brand = "Bic";
            InkColor = "Black";
            InkLevel = 100;
            MaxInk = 100;
            HasLid = true;
        }


        //Write() and Write(characterCount) - lower ink level according to the number of characters written,

        // assuming 10 characters for the version without parameters
        public void Write()
        {
            characterCount = 10;
        }

        //One character equals 0.05mL of ink usage
        public void Write(double characterCount)
        {
            characterCount -= 0.05 * characterCount;
        }


    }
}
