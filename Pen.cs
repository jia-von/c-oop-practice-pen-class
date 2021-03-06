﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Practice
{
    //Create a 'Pen' class that has the following properties:
    class Pen
    {

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
                } 
                else
                {
                    if(value<0)
                    {
                        throw new Exception("Ink is too low");
                    }
                    _inkLevel = Math.Round(value/5, 0)*5;// math.round method https://stackoverflow.com/questions/1531695/round-to-nearest-five
                }
            } }
        public double MaxInk { get; set; }
        public bool HasLid { get; set; } //Boolean cause it is only yes/no cap.

        //create a constructor
        public Pen()
        {
            Brand = "Bic";
            InkColor = "Black";
            InkLevel = 100; //Default at 100%
            MaxInk = 10; // This one has the value of mL
            HasLid = true; //true means it has cap on
        }
        
        public Pen(string brand, string inkColor, double maxInk, double inkLevel, bool hasLid)
        {
            Brand = brand;
            InkColor = inkColor;
            InkLevel = inkLevel;
            MaxInk = maxInk; // This one has the value of mL
            HasLid = hasLid; //true means it has cap on
        }

        // assuming 10 characters for the version without parameters
        public void Write()
        {
            //MaxInk -= 0.5;
            //InkLevel = (MaxInk / 10) * 100;
            InkLevel = ((MaxInk - 0.5) / MaxInk) * 100;
            
        }

        //One character equals 0.05mL of ink usage
        //TODO make the MaxInk/10 dynamic
        public void Write(double characterCount)
        {
            //MaxInk -= 0.05 * characterCount;
            //InkLevel = (MaxInk/maxInk)*100;
            InkLevel = ((MaxInk - (0.05 * characterCount)) / MaxInk) * 100;
        }


    }
}
