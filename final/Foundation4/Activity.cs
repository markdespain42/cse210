using System;
using System.Runtime.InteropServices;

public class Activity {

    private string _activityName;
    public DateTime _date;
    private string _description;
    public int _duration;

    private int _speed;
    // (distance / minutes) * 60
    
    private int _distance;
    private int _pace;
    // (minutes / distance)
    public virtual int Distance() {
        int _distance = 0;
        return _distance;
    }
    public virtual int Pace() {
        int _pace = 0;
        return _pace;
    }
    public virtual int Speed() {
        int _speed = 0;
        return _speed;
    }
    public virtual string GetSummary() {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_duration} min) - Distance: {Distance():0.0} miles, Speed: {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}