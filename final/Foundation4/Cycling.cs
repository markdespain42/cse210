using System;

public class Cycling : Activity {

    public override string Calculate() 
    {
        //speed km/h
        return "";
    }
    public override int Distance() {

        return 0;
    }
    public override string Pace() {

        return "";
    }

    public override string Speed() {

        return "";
    }
    public override string GetSummary(string date, string time, string distance, string speed, string pace) {
        return $"Date: {date}\nTime: {time}\nDistance: {distance}\nSpeed: {speed}\nPace: {pace}";
    }

}