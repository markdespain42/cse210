using System;

public class Product
{
    private string _productName;
    private int _price;
    private int _quantity;
    private int _product_id;

    public string ProductInfo(string productName, int product_id, int price, int quantity) {
        _productName = productName;
        _price = price;
        _quantity = quantity;
        _product_id = product_id;

        int productPrice = _price * _quantity;

        return $"{_productName}, {_product_id} , {productPrice}";
    }

}