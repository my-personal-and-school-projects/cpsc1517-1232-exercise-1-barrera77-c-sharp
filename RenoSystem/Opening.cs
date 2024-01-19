using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RenoSystem;
using Utils;



namespace RenoSystem
{
    /// <summary>
    /// The purpose of this exercise is the use of simple data types to represent the primary objects for managing renovation projects
    /// </summary>
    public class Opening
    {
        //Fields
        private int _Edging;
        private const int _EDGING = 10;
        private int _Height;
        private const int _HEIGHT = 120;
        private int _Width;
        private const int _WIDTH = 50;


        //Properties
       public int Height
        {
            get 
            {
                return _Height; 
            }
            set
            {
                if(!Utilities.IsValidMinimum(value, _HEIGHT))
                {
                    throw new ArgumentException($"Height cannot be less than {_HEIGHT}cm");
                }
                _Height = value;
            }            
        }

        public int Width
        {
            get
            {
                return _Width;
            }

            set
            {
                if(!Utilities.IsValidMinimum(value, _WIDTH))
                {
                    throw new ArgumentException($"Width cannot be less than {_WIDTH}cm");
                }
                _Width = value;
            }
        }

        public int Edging
        {
            get
            {
                return _Edging;
            }

            set
            {
               /*if(value < 0 || value > 0 && value < 10)
                {
                    throw new ArgumentException("Edging cannot be less 0 or less than 10");
                }
                _Edging = value;*/

                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("Edging cannot be less than 0");
                }
                else if (Utilities.IsNonZeroPositive(value) && !Utilities.IsValidMinimum(value, _EDGING))
                {
                    throw new ArgumentException("Edging should be equals or greater than 10");
                }
                _Edging = value;
            }
        }

        public int Area
        {
            get
            {
                return (Width * Height);
            }
        }

        public int Perimeter
        {
            get
            {
                return ((_Width + _Height) * 2);
            }
        }

        //Auto-implemented property
        public OpeningType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="type"></param>
        /// <param name="edging"></param>
        public Opening(int width, int height, OpeningType type, int edging = 0)
        {

            Height = height;
            Width = width;
            Type = type;
            Edging = edging;
        }

        //Methods

        /// <summary>
        /// Overides the default ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Width},{Height},{Type},{Edging}";

        }
    }
}


