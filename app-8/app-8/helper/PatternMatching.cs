using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    public class RGBColor
    {
        internal byte Red { get; }
        internal byte Green { get; }
        internal byte Blue { get; }

        internal RGBColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString() => $"rgb({Red}, {Green}, {Blue})";
    }

    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public static class PatternMatching
    {
        public static RGBColor FromRainbow(Rainbow rainbowBolor)
        {
            switch (rainbowBolor)
            {
                case Rainbow.Red:
                    return new RGBColor(0xFF, 0x00, 0x00);
                case Rainbow.Orange:
                    return new RGBColor(0xFF, 0x7F, 0x00);
                case Rainbow.Yellow:
                    return new RGBColor(0xFF, 0xFF, 0x00);
                case Rainbow.Green:
                    return new RGBColor(0x00, 0xFF, 0x00);
                case Rainbow.Blue:
                    return new RGBColor(0x00, 0x00, 0xFF);
                case Rainbow.Indigo:
                    return new RGBColor(0x4B, 0x00, 0x82);
                case Rainbow.Violet:
                    return new RGBColor(0x94, 0x00, 0xD3);
                default:
                    throw new ArgumentException(message: "invalid enum value", paramName: nameof(rainbowBolor));
            };
        }

        internal static RGBColor TasteTheRainbow(Rainbow rainbowColor) =>
            rainbowColor switch
            {
                Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(rainbowColor)),
            };

        public static void Run()
        {

        }

        //***********************************************

        //private static string HandleHttpError(Exception ex, string text)
        //{
        //    switch (ex)
        //    {
        //        case HttpException httpEx:
        //            return httpEx.StatusCode switch
        //            {
        //                404 => "[NOT FOUND]",
        //                500 => "[INTERNAL SERVER ERROR]",
        //                _ => text
        //            };
        //        default:
        //            return text;
        //    }
        //}

        //private static string HandleHttpError(Exception ex, string text)
        //{
        //    if (ex is HttpException { StatusCode: 404 })
        //    {
        //        return $"[NOT FOUND]";
        //    }
        //    else if (ex is HttpException { StatusCode: 500 })
        //    {
        //        return $"[INTERNAL SERVER ERROR]";
        //    }
        //    else
        //    {
        //        return text;
        //    }
        //}

    }
    //***********************************************
    class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegion { get; set; }
    }

    static class PropertyPatterns
    {
        internal static decimal ComputeSalesTax(
            Address location, decimal salePrice) =>
            location switch
            {
                { State: "Fars" } => salePrice * 0.06m,
                { State: "Tehran", City: "Tehran" } => salePrice * 0.056m,

                // Other cases removed for brevity...
                _ => 0M
            };
    }

    //***********************************************
    static class TuplePatterns
    {
        internal static string RockPaperScissors(
            string first,
            string second)
            => (first, second) switch
            {
                ("rock", "paper") => "Rock is covered by Paper. Paper wins!",
                ("rock", "scissors") => "Rock breaks Scissors. Rock wins!",
                ("paper", "rock") => "Paper covers Rock. Paper wins!",
                ("paper", "scissors") => "Paper is cut by Scissors. Scissors wins!",
                ("scissors", "rock") => "Scissors is broken by Rock. Rock wins!",
                ("scissors", "paper") => "Scissors cuts Paper. Scissors wins!",
                (_, _) => "tie"
            };
    }
    //***********************************************
    class Shape
    {
        protected internal double Height { get; }
        protected internal double Length { get; }

        protected Shape(double height = 0, double length = 0)
        {
            Height = height;
            Length = length;
        }
    }

    class Circle : Shape
    {
        internal double Radius => Height / 2;
        internal double Diameter => Radius * 2;
        internal double Circumference => 2 * Math.PI * Radius;

        internal Circle(double height = 10, double length = 10)
            : base(height, length) { }
    }

    class Rectangle3 : Shape
    {
        internal bool IsSquare => Height == Length;

        internal Rectangle3(double height = 10, double length = 10)
            : base(height, length) { }
    }

    static class ObjectPatterns
    {
        internal static string ShapeDetails(this Shape shape)
            => shape switch
            {
                Circle c => $"circle with (C): {c.Circumference}",
                Rectangle3 s when s.IsSquare => $"L:{s.Length} H:{s.Height}, square",
                Rectangle3 r => $"L:{r.Length} H:{r.Height}, rectangle",
                _ => "Unknown shape!" // Discard
            };
    }

    //***********************************************
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) => (X, Y) = (x, y);
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }

    enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }

    static class PositionalPatterns
    {
        internal static Quadrant AsQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            (_, _) => Quadrant.OnBorder, // Either are 0, but not both
            _ => Quadrant.Unknown
        };
    }

}