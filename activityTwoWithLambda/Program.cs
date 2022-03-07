using System.Linq;
using System;
namespace activityTwoByLinq
{
    public class Fruit
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }
    }
    public enum Color
    {
        Red, Green, Yellow
    }
    class activityTwoByLinq
    {
        List<Fruit> fruits = new List<Fruit>
        {
            new Fruit{ Id = "f1", Name = "Apple", Color = Color.Red, Price = 23.0,},
            new Fruit{ Id = "f2", Name = "Banana", Color = Color.Yellow, Price = 10.0,},
            new Fruit{ Id = "f3", Name = "Pineapple", Color = Color.Yellow, Price = 55.0,},
            new Fruit{ Id = "f4", Name = "Cherry", Color = Color.Red, Price = 40.0,},
            new Fruit{ Id = "f5", Name = "Watermelon", Color = Color.Green, Price = 28.0,},
            new Fruit{ Id = "f6", Name = "Strawberry", Color = Color.Red, Price = 33.0,}
        };

        public static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            //Get ordered fruits in descending order.
            Console.WriteLine("Get ordered fruits in descending order");
            activityTwoByLinq activityTwoByLinq = new activityTwoByLinq();
            IEnumerable<Fruit> fInDescendingOrder = activityTwoByLinq.fruitsInDescendingOrderMethod(activityTwoByLinq);
            activityTwoByLinq.displayAllMeth(fInDescendingOrder);

            Console.WriteLine();

            //2) Get ordered fruits in ascending order.
            Console.WriteLine("Get ordered fruits in ascending order.");
            IEnumerable<Fruit> fInAscendingOrder = activityTwoByLinq.fruitsInAscendingOrderMethod(activityTwoByLinq);
            activityTwoByLinq.displayAllMeth(fInAscendingOrder);
            Console.WriteLine();


            //3) Get red and green fruits.
            Console.WriteLine(" Get red and green fruits.");
            IEnumerable<Fruit> getRedAndGreenFruit = activityTwoByLinq.getRedAndGreenFruitMethod(activityTwoByLinq);
            activityTwoByLinq.displayAllMeth(getRedAndGreenFruit);
            Console.WriteLine();

            //4) Get cheapest fruit.
            Console.WriteLine(" Get cheapest fruit.");
            IEnumerable<Fruit> cheaFruits = activityTwoByLinq.getCheapFruitsMethod(activityTwoByLinq);
            activityTwoByLinq.displayAllMeth(cheaFruits);
            Console.WriteLine();

            //5) Get most expensive fruit.
            Console.WriteLine("  Get most expensive fruit.");
            var expensiveFruits = activityTwoByLinq.getExpensiveFruitsMethod(activityTwoByLinq);
            activityTwoByLinq.displayAllMeth(expensiveFruits);
            Console.WriteLine();

            //6) Get fruits by budget of 40 RS.
            Console.WriteLine("   Get fruits by budget of 40 RS.");
            var forBudget40 = activityTwoByLinq.forBudget40Method(activityTwoByLinq);
            activityTwoByLinq.displayAllMeth(forBudget40);
            Console.WriteLine();

            //7) Get count of red fruits.
            Console.WriteLine("  Get count of red fruits.");
            var redFruits = activityTwoByLinq.redFruitsMethod(activityTwoByLinq);
            Console.WriteLine(redFruits.ToList().Count);
            //activityTwoByLinq.displayAllMeth(redFruits);
            Console.WriteLine();

            //8) Group fruits with colors.

            Console.WriteLine(" Group fruits with colors.");
            activityTwoByLinq.groupByColorMethod(activityTwoByLinq);
            // activityTwoByLinq.displayAllMeth(groupByColor);
            Console.WriteLine();

        }
        public void groupByColorMethod(activityTwoByLinq activityTwoByLinq)
        {

            var colorGroup = activityTwoByLinq.fruits.GroupBy(Fruit => Fruit.Color);
            Console.WriteLine("Fruits group by colors");
            foreach (var Group in colorGroup)
            {
                Console.WriteLine(("Color  = " + Group.Key));
                foreach (var cx in Group)
                {
                    Console.WriteLine(cx.Name);
                }
            }


        }


        public IEnumerable<Fruit> redFruitsMethod(activityTwoByLinq activityTwoByLinq)
        {

            var expensiveFruit = activityTwoByLinq.fruits.Where(Fruit => Fruit.Color == Color.Red);
            return expensiveFruit;

        }
        public IEnumerable<Fruit> forBudget40Method(activityTwoByLinq activityTwoByLinq)
        {
            double expensive = 40;
            var expensiveFruit = activityTwoByLinq.fruits.Where(Fruit => Fruit.Price <= expensive);
            return expensiveFruit;

        }
        public IEnumerable<Fruit> getExpensiveFruitsMethod(activityTwoByLinq activityTwoByLinq)
        {
            double expensive = 40;
            var expensiveFruit = activityTwoByLinq.fruits.Where(Fruit => Fruit.Price > expensive);
            return expensiveFruit;

        }
        public IEnumerable<Fruit> getCheapFruitsMethod(activityTwoByLinq activityTwoByLinq)
        {
            double myBudget = 20;
            var getRedAndGreenFruit = activityTwoByLinq.fruits.Where(Fruit => Fruit.Price <= myBudget);
            return getRedAndGreenFruit;
        }
        public IEnumerable<Fruit> getRedAndGreenFruitMethod(activityTwoByLinq activityTwoByLinq)
        {
            var getRedAndGreenFruit = activityTwoByLinq.fruits.Where(Fruit => Fruit.Color == Color.Red || Fruit.Color == Color.Green);
            return getRedAndGreenFruit;
        }

        public IEnumerable<Fruit> fruitsInDescendingOrderMethod(activityTwoByLinq activityTwoByLinq)
        {
            var fruitsInDescendingOrder = activityTwoByLinq.fruits.OrderByDescending(Fruit => Fruit.Name);
            return fruitsInDescendingOrder;
        }
        public IEnumerable<Fruit> fruitsInAscendingOrderMethod(activityTwoByLinq activityTwoByLinq)
        {
            var fruitsInDescendingOrder = activityTwoByLinq.fruits.OrderBy(Fruit => Fruit.Name);
            //from fruit in activityTwoByLinq.fruits
            //                              orderby fruit.Name ascending
            //                              select fruit;
            return fruitsInDescendingOrder;
        }
        public void displayAllMeth(IEnumerable<Fruit> somethingIn)
        {
            foreach (var fru in somethingIn)
            {
                Console.WriteLine(fru.Name);
            }
        }









    }


}
