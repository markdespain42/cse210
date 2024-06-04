using System;

public class Order {

    private string _customerName;

    private List<string> _products = new List<string>();

    Customer customer = new Customer();
    Address address = new Address();
    Product productstuff = new Product();

    public void AddProduct(string productName) {
        _products.Add(productName);
    }
    public string OrderList(string customerName) {
        _customerName = customerName;

        return "";
    }
    public int OrderPrice(int productPrice) {
        int total = 0;
        foreach (string product in _products) {
            total += productPrice;
        }
        return total;
    }
    public string PackingLabel(string _productName, int _product_id, int _price, int _quantity) {
        foreach (string product in _products) {
            if (product == _productName) {
                productstuff.ProductInfo(_productName, _product_id, _price, _quantity);

                return $"{_productName}, {_product_id}";
            }
            else {
                return $"Product: {_productName} Not Found";
            }
        }

        return "";
    }
    public string ShippingLabel(string _customerName, string _streetAddress, string _city, string _state, string _country) {
        customer.CustomerInfo(_customerName, _country);

        return $"{_customerName}, {address.AddressInfo(_streetAddress, _city, _state, _country)}";
    }
}