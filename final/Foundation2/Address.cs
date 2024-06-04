using System;

public class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public string AddressInfo(string streetAddress, string city, string state, string country) {
    _streetAddress = streetAddress;
    _city = city;
    _state = state;
    _country = country;

    if (_country == "USA") {
        return $"{_streetAddress}, {_city}, {_state}, USA";
    }
    else {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    }
}