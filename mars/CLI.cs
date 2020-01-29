using System;

namespace mars
{
    public class Program
    {
        static String Usage()
        {
            return "This Mars Rover Program expects input in the form of:" + Environment.NewLine +
                   "<grid size east (int)> <grid size north (int)>" + Environment.NewLine +
                   "<starting position east (int)> <starting position north (int)> <rover heading ('N','S','E','W')>" + Environment.NewLine +
                   "<movement instructions any length String of : ('L','R','M')>" + Environment.NewLine;
        }

        public static void Main(string[] args)
        {
            try
            {
                String grid = Console.ReadLine();
                var grid_points = grid.Split(" ");

                if (grid_points.Length > 2)
                {
                    throw new FormatException();
                }

                if (grid_points.Length < 2)
                {
                    throw new FormatException();
                }

                int grid_x = int.Parse(grid_points[0]);
                int grid_y = int.Parse(grid_points[1]);

                if (grid_x < 0 || grid_y < 0)
                {
                    throw new FormatException();
                }

                Point grid_point = new Point(grid_x, grid_y);

                while (true)
                {
                    String rover_pos = Console.ReadLine();
                    var rover_pos_split = rover_pos.Split(" ");

                    if (rover_pos_split.Length > 3)
                    {
                        throw new FormatException();
                    }

                    if (rover_pos_split.Length < 3)
                    {
                        throw new FormatException();
                    }

                    int rover_x = int.Parse(rover_pos_split[0]);
                    int rover_y = int.Parse(rover_pos_split[1]);

                    if (rover_x < 0 || rover_y < 0)
                    {
                        throw new FormatException();
                    }

                    Point rover_start_point = new Point(rover_x, rover_y);

                    String rover_heading = rover_pos_split[2];

                    if (rover_heading.Length > 1)
                    {
                        throw new FormatException();
                    }

                    Direction? rover_start_direction = DirectionStateMachine.DirectionFromString(rover_heading);
                    if (!rover_start_direction.HasValue)
                    {
                        throw new FormatException();
                    }

                    Rover rover = new Rover(grid_point, rover_start_point, rover_start_direction.Value);

                    String rover_instruct = Console.ReadLine();
                    foreach (char x in rover_instruct)
                    {
                        if (x != 'R' && x != 'L' && x != 'M')
                        {
                            throw new FormatException();
                        }

                        try
                        {
                            switch (x)
                            {
                                case 'R':
                                    rover.TurnRight();
                                    break;
                                case 'L':
                                    rover.TurnLeft();
                                    break;
                                case 'M':
                                    rover.Move();
                                    break;

                            }
                        }
                        catch (Rover.RoverOutOfBoundsException)
                        {
                            Console.Error.WriteLine("Rover instructed to move out of grid bounds, command ignored, rover remains in bounds");
                        }
                    }


                    Console.WriteLine(rover.ToString());
                }

            }
            catch (FormatException)
            {
                //if FormatException
                Console.Error.WriteLine("Poorly Formatted Input");
                Console.WriteLine(Usage());

            }
            catch (OverflowException)
            {
                //if FormatException
                Console.Error.WriteLine("Int Overflow, Keep Inputs below 2,147,483,647");
                Console.WriteLine(Usage());

            }
            catch (Exception)
            {
                Console.Error.WriteLine("Unknown Failure");

            }
        }
    }
}
