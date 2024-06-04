using System;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

public class Customer
{
    public string _name;
    public string _address;

    public string CustomerInfo(string name, string address) {
        _name = name;
        _address = address;

        return $"{_name}, {_address}";
    }
}   