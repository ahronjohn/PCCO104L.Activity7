namespace PCCO104L.Activity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Siamese = new Cat(10.5, "Siamese");
            Siamese.Scratch();

            Dog Labrador = new Dog(30.20, "Labrador");
            Labrador.Bark();

            Bird Eigel = new Bird(40.20, "Eigel");
            Eigel.Spitting();
        }
    }


    public class Cat
    {
        public string Breed { get; set; }

        private double _Weight { get; set; }

        public Cat() { }

        public Cat(double weight)
        {
            _Weight = weight;
        }

        public Cat(double weight, string breed) : this(weight)
        {

            Breed = breed;
        }

        public void Scratch()
        {
            Console.WriteLine($"{Breed} - {_Weight} Scratch");
        }
    }

    public class Dog
    {
        public string Breed { get; set; }

        private double _Weight { get; set; }

        public Dog() { }

        public Dog(double weight)
        {
            _Weight = weight;
        }

        public Dog(double weight, string breed) : this(weight)
        {

            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Breed} - {_Weight} Bark!");
        }
    }

    public class Bird
    {
        public string Breed { get; set; }

        private double _Weight { get; set; }

        public Bird() { }

        public Bird(double weight)
        {
            _Weight = weight;
        }

        public Bird(double weight, string breed) : this(weight)
        {

            Breed = breed;
        }

        public void Spitting()
        {
            Console.WriteLine($"{Breed} - {_Weight} Spitting!");
        }
    }
}

