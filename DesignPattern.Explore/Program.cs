using DesignPattern.Explore.Structural.Bridge;

IColor color = new RedColor();

Shape redCircle = new Circle(color);

redCircle.Draw();