using System;

public class XeMay : IMove
{
    public string TenXe { get; set; }
    public double GetSpeed() => 60.0;
    public double GetOperatingCost() => 1500.0;
}

public class OTO : IMove
{
    public string TenXe { get; set; }
    public double GetSpeed() => 90.0;
    public double GetOperatingCost() => 3500.0;
}

public class XeDap : IMove
{
    public string TenXe { get; set; }
    public double GetSpeed() => 15.0;
    public double GetOperatingCost() => 0.0;
}