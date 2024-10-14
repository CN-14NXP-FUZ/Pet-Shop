using System;
using System.Collections.Generic;

namespace Pet_Shop.model
{
    public class Product
    {
        private string id;
        private string name;
        private string nameCategory;
        private int price;
        private int stock;
        private string description;
        private string imageUrl;
        private bool isAvailable;
        private int discount;
        private string typeProduct; //new or sale 
        private List<String> listSize;
        private List<string> listThumb;

        // Constructor
        public Product(string id, string name, string nameCategory, int price, int stock, string description, string imageUrl, bool isAvailable, int discount,string typeProduct, List<String> listSize,  List<string> listThumb)
        {
            this.id = id;
            this.name = name;
            this.nameCategory = nameCategory;
            this.price = price;
            this.stock = stock;
            this.description = description;
            this.imageUrl = imageUrl;
            this.isAvailable = isAvailable;
            this.discount = discount;
            this.typeProduct = typeProduct;
            this.listSize = listSize;
            this.listThumb = listThumb;
        }

        // Properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string NameCategory
        {
            get { return nameCategory; }
            set { nameCategory = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string TypeProduct
        {
            get { return typeProduct; }
            set { typeProduct = value; }
        }

        public List<string> ListSize
        {
            get { return listSize; }
            set { listSize = value; }
        }

        public List<string> ListThumb
        {
            get { return listThumb; }
            set { listThumb = value; }
        }
    }
}
