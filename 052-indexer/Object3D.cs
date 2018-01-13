using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_indexer
{
    class Object3D
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }

        // Indexer for integers
        public double this[int idx]
        {
            get
            {
                switch(idx)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }

            set
            {
                switch(idx)
                {
                    case 0:
                        this.X = value;
                        break;
                    case 1:
                        this.Y = value;
                        break;
                    case 2:
                        this.Z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        // Indexer for strings
        public double this[string property]
        {
            get
            {
                switch(property)
                {
                    case "x":
                    case "X":
                        return this.X;
                    case "y":
                    case "Y":
                        return this.Y;
                    case "z":
                    case "Z":
                        return this.Z;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }

            set
            {
                switch(property)
                {
                    case "x":
                    case "X":
                        this.X = value;
                        break;
                    case "y":
                    case "Y":
                        this.Y = value;
                        break;
                    case "z":
                    case "Z":
                        this.Z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Object3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        
    }
}
