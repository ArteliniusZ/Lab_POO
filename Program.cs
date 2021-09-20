using System;

namespace POOlab1
{

    public class Monitor
    {
        private string color { get; set; }
        private int dimensions { get; set; }
        private string resolution { get; set; }




        public Monitor(string nameColor, int dimSpec, string resSpec)
        {
            this.color = nameColor;
            this.dimensions = dimSpec;
            this.resolution = resSpec;
        }

        public string getColor()
        {
            return color;
        }
        public int getDimensions()
        {
            return dimensions;
        }
        public string getResolution()
        {
            return resolution;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setDimensions(int dimensions)
        {
            this.dimensions = dimensions;
        }

        public void setResolution(string resolution)
        {
            this.resolution = resolution;
        }

     




        static void Main(string[] args)
        {
            Monitor mon = new Monitor("Blue", 27, "1920x1080");
            Console.WriteLine("1st Monitor");
            Console.WriteLine("Monitor's color: " + mon.getColor());
            Console.WriteLine("Monitor's dimensions: " + mon.getDimensions() + " inches");
            Console.WriteLine("Monitor's resolution: " + mon.getResolution());

            mon.color = "Purple";
            mon.dimensions = 25;
            mon.resolution = "1780x1080";

            Console.WriteLine("Changed product: ");
            Console.WriteLine("Monitor's color: " + mon.getColor());
            Console.WriteLine("Monitor's dimensions: " + mon.getDimensions() + " inches");
            Console.WriteLine("Monitor's resolution: " + mon.getResolution());

            Console.WriteLine("----------------------------");

        
            Monitor mon1 = new Monitor("Red", 23, "1550x1080");
            Console.WriteLine("2nd Monitor");
            Console.WriteLine("Monitor's color: " + mon1.getColor());
            Console.WriteLine("Monitor's dimensions: " + mon1.getDimensions() + " inches");
            Console.WriteLine("Monitor's resolution: " + mon1.getResolution());


            Console.WriteLine("----------------------------");
            Console.WriteLine("Comparing the monitors' specs: ");
            Console.WriteLine("Monitor's color: " + mon.getColor());
            Console.WriteLine("Monitor's dimensions: " + mon.getDimensions() + " inches");
            Console.WriteLine("Monitor's resolution: " + mon.getResolution());
            Console.WriteLine("---");
            Console.WriteLine("Monitor's color: " + mon1.getColor());
            Console.WriteLine("Monitor's dimensions: " + mon1.getDimensions() + " inches");
            Console.WriteLine("Monitor's resolution: " + mon1.getResolution());


        }
    }
}

 




