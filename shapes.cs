class Shape{
    public string? Name { get; set; }
    public virtual double Area(){return 0.0; }


}
class Circle : Shape {
    public double Radius { get; set; }

    public override double Area() {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area() {
        return Width * Height;
    }
}

class Triangle : Shape {
    public double Base { get; set; }
    public double Height { get; set; }

    public override double Area() {
        return (Base * Height) / 2;
    }
}

