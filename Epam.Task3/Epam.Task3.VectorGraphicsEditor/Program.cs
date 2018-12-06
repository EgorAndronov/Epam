using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Program
    {
        private enum TypeFigure
        {
            Line,
            Round,
            Circle,
            Ring,
            Rectangle,
        }

        private static void Main(string[] args)
        {
            try
            {
                List<Figure> listFigure = new List<Figure>();

                while (true)
                {
                    Console.WriteLine("Select the type of figure:");
                    foreach (TypeFigure elem in Enum.GetValues(typeof(TypeFigure)))
                    {
                        Console.WriteLine($"{(int)elem + 1}. {elem}");
                    }

                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        string name = string.Empty;
                        int len;
                        double radius;
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Enter line name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter line length:");
                                if (int.TryParse(Console.ReadLine(), out len))
                                {
                                    Line line = new Line(name, len);
                                    listFigure.Add(line);
                                }

                                break;
                            case 2:
                                Console.WriteLine("Enter round name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter round radius:");
                                if (double.TryParse(Console.ReadLine(), out radius))
                                {
                                    Round round = new Round(name, radius);
                                    listFigure.Add(round);
                                }

                                break;
                            case 3:
                                Console.WriteLine("Enter circle name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter circle radius:");
                                if (double.TryParse(Console.ReadLine(), out radius))
                                {
                                    Circle circle = new Circle(name, radius);
                                    listFigure.Add(circle);
                                }

                                break;
                            case 4:
                                Console.WriteLine("Enter ring name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter ring inner radius:");
                                if (int.TryParse(Console.ReadLine(), out int radiusIn))
                                {
                                    Console.WriteLine("Enter ring outer radius:");
                                    if (int.TryParse(Console.ReadLine(), out int radiusOut))
                                    {
                                        Ring ring = new Ring(name, radiusIn, radiusOut);
                                        listFigure.Add(ring);
                                    }
                                }

                                break;
                            case 5:
                                Console.WriteLine("Enter rectangle name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter rectangle first side:");
                                if (int.TryParse(Console.ReadLine(), out int side1))
                                {
                                    Console.WriteLine("Enter rectangle second side:");
                                    if (int.TryParse(Console.ReadLine(), out int side2))
                                    {
                                        Rectangle rect = new Rectangle(name, side1, side2);
                                        listFigure.Add(rect);
                                    }
                                }

                                break;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Created figures:");

                    foreach (var elem in listFigure)
                    {
                        Console.WriteLine(elem.Show());
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
