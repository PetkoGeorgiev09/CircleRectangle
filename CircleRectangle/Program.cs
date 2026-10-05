using CircleRectangle;

Console.Write("Въведете дължина на страната a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Въведете дължина на страната b: ");
double b = double.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle(a, b);
rectangle.AreaRectangle();

Console.Write("Въведете дължина на радиус: ");
double r = double.Parse(Console.ReadLine());
Circle circle = new Circle(r);
circle.AreaCircle();
