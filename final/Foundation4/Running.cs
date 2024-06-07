using System;

public class Running : Activity {

    private int _distance;
    private int _minutes;

    public void RunningInfo(int minutes, int distance) {
        //distance
        _distance= distance;
        _minutes = minutes;
    }
    public override int Distance() {

        return _distance;
    }
    public override int Pace() {

        return (_minutes / _distance);
    }

    public override int Speed() {

        return (_distance / _minutes) * 60;
    }
    public override string GetSummary() {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_duration} min) - Distance: {Distance():0.0} miles, Speed: {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}