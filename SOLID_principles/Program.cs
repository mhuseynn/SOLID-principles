using System;


//SingleRes
////Before
//public class Employee
//{
//    public void CalculateSalary()
//    {
//        // calculate salary logic
//    }

//    public void GenerateReport()
//    {
//        // generate report logic
//    }
//}

////After
//public class Employee
//{
//    public void CalculateSalary()
//    {
//        // calculate salary logic
//    }
//}

//public class ReportGenerator
//{
//    public void GenerateReport(Employee employee)
//    {
//        // generate report logic
//    }
//}
//==================================================================================================================

//OPEN closed
//Before
//public class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//public class AreaCalculator
//{
//    public double CalculateArea(Rectangle rectangle)
//    {
//        return rectangle.Width * rectangle.Height;
//    }
//}

//After
//public abstract class Shape
//{
//    public abstract double CalculateArea();
//}

//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//public class Circle : Shape
//{
//    public double Radius { get; set; }

//    public override double CalculateArea()
//    {
//        return 3.14 * Radius * Radius;
//    }
//}


//==================================================================================================================
//LIskov
//Before
//public class Bird
//{
//    public virtual void Fly()
//    {

//    }
//}

//public class Penguin : Bird
//{
//    public override void Fly()
//    {


//    }
//}

////After
//public interface IFlyable
//{
//    void Fly();
//}

//public class Bird : IFlyable
//{
//    public void Fly()
//    {

//    }
//}

//public class Penguin : IFlyable
//{
//    public void Fly()
//    {


//    }
//}

////==================================================================================================================
//Interface
//Before
//public interface IWorker
//{
//    void Work();
//    void TakeBreak();
//}

//public class Manager : IWorker
//{
//    public void Work()
//    {

//    }

//    public void TakeBreak()
//    {

//    }
//}
////After
//public interface IWorkable
//{
//    void Work();
//}

//public interface IBreakable
//{
//    void TakeBreak();
//}

//public class Manager : IWorkable, IBreakable
//{
//    public void Work()
//    {

//    }

//    public void TakeBreak()
//    {

//    }
//}
////==================================================================================================================
//Dependency
//Before
//public class LightBulb
//{
//    public void TurnOn()
//    {

//    }

//    public void TurnOff()
//    {

//    }
//}

//public class Switch
//{
//    private LightBulb bulb;

//    public Switch(LightBulb bulb)
//    {
//        this.bulb = bulb;
//    }

//    public void Operate()
//    {

//        bulb.TurnOn();
//    }
//}

//After

//public interface ISwitchable
//{
//    void TurnOn();
//    void TurnOff();
//}

//public class LightBulb : ISwitchable
//{
//    public void TurnOn()
//    {

//    }

//    public void TurnOff()
//    {

//    }
//}

//public class Switch
//{
//    private ISwitchable device;

//    public Switch(ISwitchable device)
//    {
//        this.device = device;
//    }

//    public void Operate()
//    {

//        device.TurnOn();
//    }
//}