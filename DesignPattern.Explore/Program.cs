using DesignPattern.Explore.Structural.Adapter;

Adaptee adapt = new Adaptee();
ITarget target = new Adapter(adapt);

target.Request();

