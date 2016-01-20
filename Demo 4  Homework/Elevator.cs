using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * Copyright (C) Finnish Software Oy (FiSo) 
 * 
 * This file is part of the MyFineSoftware project.
 * 
 * Created: <<20.01.2016>> 
 * Authors: <<Sampsa Kautto>> 
 */
namespace Demo_4__Homework
{
    class Elevator
    {
        


        private readonly int TopFloor = 5;
        private readonly int MinFloor = 1;
        private int floor;

        //property
        public int Floor
        
        {
            get
            {
                return floor;
            }

            set
            {
                if (value <= TopFloor && value >= MinFloor) floor = value;
                else
                {
                    Console.WriteLine("Not Such Floor");
                    
                }
            }

        }
    }
}
