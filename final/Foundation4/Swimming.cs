using System;

public class Swimming : Activity {

    public override string Calculate()
    {
        //number of laps. Each lap is 50 meters
        return "";
    }
    public override int Distance() {
        int distance = 0;
        return distance;
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