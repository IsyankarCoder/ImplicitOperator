using System.Reflection.Metadata.Ecma335;

public class Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

  /* public static implicit operator Location(Coordinate coordinate)
    {
        return new Location(x: coordinate.X, y: coordinate.Y);

    }*/

    public static explicit operator Location(Coordinate coordinate)
    {
        return new Location(x: coordinate.X, y: coordinate.Y);

    }

    public static implicit operator double(Coordinate coordinate)
    {
        return coordinate.X + coordinate.Y;
    }
}