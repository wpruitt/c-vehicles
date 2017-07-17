using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle : ItestInterface
{

    
    void Fly();
}

public interface ItestInterface
{
    void Drive();
    void Start();
    void Stop();
}


public class Vehicle
{
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
}
public class JetSki : Vehicle, IVehicle, ItestInterface
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    // public int PassengerCapacity { get; set; }
    public bool Winged { get; set; }
    // public string TransmissionType { get; set; }
    // public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : Vehicle, IVehicle, ItestInterface
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    // public int PassengerCapacity { get; set; }
    public bool Winged { get; set; } = false;
    // public string TransmissionType { get; set; } = "Manual";
    // public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : Vehicle, IVehicle, ItestInterface
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
//   public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
//   public string TransmissionType { get; set; } = "None";
//   public double EngineVolume { get; set; } = 31.1;
  public double MaxLandSpeed { get; set; }
  public double MaxAirSpeed { get; set; } = 309.0;
  public void Drive()
  {
    Console.WriteLine("Slowly meanders down taxiways and runways, getting in everyone's way");
  }

  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Start()
  {
    throw new NotImplementedException();
  }

  public void Stop()
  {
    throw new NotImplementedException();
  }
}


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List<IVehicle> flyingVehicles = new List<IVehicle>();
        flyingVehicles.Add(new Cessna());
        // With a single `foreach`, have each vehicle Fly()
        foreach (IVehicle vehicle in flyingVehicles)
        {
            vehicle.Fly();
            vehicle.Drive();
            // Cessna cessnaProps = (Cessna)vehicle;
            // foreach (var cessna in cessnaProps)
            // {
            // Console.WriteLine(vehicle.MaxAirSpeed);
            // }
        }

        // Build a collection of all vehicles that operate on roads
        List<IVehicle> roadVehicles = new List<IVehicle>();
        roadVehicles.Add(new Motorcycle());

        // With a single `foreach`, have each road vehicle Drive()
        foreach (ItestInterface vehicle in roadVehicles)
        {
            vehicle.Drive();
        }


        // Build a collection of all vehicles that operate on water
        List<IVehicle> waterVehicles = new List<IVehicle>();
        waterVehicles.Add(new JetSki());
        
        // With a single `foreach`, have each water vehicle Drive()
        foreach (ItestInterface vehicle in waterVehicles)
        {
            vehicle.Drive();
        }
    }

}