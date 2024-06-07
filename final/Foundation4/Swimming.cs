using System;

public class Swimming : Activity {

    private int _minutes;
    private int _laps;


    public void SwimmingInfo(int minutes, int laps) {
        _minutes = minutes;
        _laps = laps;
    }
    public override int Distance() {
        return (int)(_laps * 50.0/1000.0 * 0.62);
    }
    public override int Pace() {

        return (_minutes / Distance());
    }

    public override int Speed() {

        return (Distance() / _minutes) * 60;
    }
    public override string GetSummary() {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_duration} min) - Distance: {Distance():0.0} miles, Speed: {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}