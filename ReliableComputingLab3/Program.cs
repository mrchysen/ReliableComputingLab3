double x, y, xx, yy;
double[] xIntr = new double[2];
double[] xIntrNew = new double[2];
double[] yIntr = new double[2];
double[] yIntrNew = new double[2];
double eps = 0.00001;
const int n = 100;
x = 1; y = 1;

Console.WriteLine("Приближенное решение методом простой итерации:");

for (int i = 0; i < n; i++)
{
    xx = (Math.Sin(y) - 1.0) / 2.0;
    yy = Math.Cos(x + 0.5) - 2.0;
    x = xx;
    y = yy;
}
Console.WriteLine("x=" + x);
Console.WriteLine("y=" + y);
Console.WriteLine();
xIntr[0] = x - eps;
xIntr[1] = x + eps;

yIntr[0] = y - eps;
yIntr[1] = y + eps;

Console.WriteLine(eps);
Console.WriteLine("x=[" + xIntr[0] + "; " + xIntr[1] + "]");
Console.WriteLine("y=[" + yIntr[0] + "; " + yIntr[1] + "]");
Console.WriteLine();
Console.WriteLine("Интервальное расширение:");

xIntrNew[0] = (Math.Sin(yIntr[0]) - 1.0) / 2.0;
xIntrNew[1] = (Math.Sin(yIntr[1]) - 1.0) / 2.0;

yIntrNew[0] = Math.Cos(xIntr[0] + 0.5) - 2.0;
yIntrNew[1] = Math.Cos(xIntr[1] + 0.5) - 2.0;

Console.WriteLine("x=[" + xIntrNew[0] + "; " + xIntrNew[1] + "]");
Console.WriteLine("y=[" + yIntrNew[0] + "; " + yIntrNew[1] + "]");
Console.WriteLine();

//проверка условия
if (xIntr[0] <= xIntrNew[0] &&
    yIntr[0] <= yIntrNew[0] &&
    xIntrNew[1] <= xIntr[1] &&
    yIntrNew[1] <= yIntr[1])
    Console.WriteLine("в полученных интервалах содержится неподвижная  точка");
else
    Console.WriteLine("в полученном интервале не содержится неподвижной точки, отображение не сжимающее");
