using System;

public class Activity {

    private string _activityName;
    private string _description;
    private int _duration;

    private int _speed;
    // (distance / minutes) * 60
    
    private int _distance;
    private int _pace;
    // (minutes / distance)

    public virtual string Calculate() {


        return "";
    }
    public virtual int Distance() {
        int distance_for_fun = 0;
        return distance_for_fun;
    }
    public virtual string Pace() {

        return "";
    }

    public virtual string Speed() {

        return "";
    }
    public virtual string GetSummary(string date, string time, string distance, string speed, string pace) {
        return $"Date: {date}\nTime: {time}\nDistance: {distance}\nSpeed: {speed}\nPace: {pace}";
    }
}