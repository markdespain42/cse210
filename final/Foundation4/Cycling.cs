using System;

public class Cycling : Activity {
    private int _minutes;
    private int _speed;

    public void CyclingInfo(int minutes, int speed, int distance) {
        _minutes = minutes;
        _speed = speed;
    }

    public override int Distance() {

        return _speed /60 * _minutes;
    }
    public override int Pace() {

        return 60 / _speed;
    }

    public override int Speed() {

        return _speed;
    }
    public override string GetSummary() {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_duration} min) - Distance: {Distance():0.0} miles, Speed: {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}