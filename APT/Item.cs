using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APT
{
    class Item
    {
        int ind, price, minPrice, maxPrice, BasePriceLenght;
        string ProductID, AmazonRG, Name;
        string sea, sen;
        HttpClient http = new HttpClient();
        
        public Item(string PID, int BPL, string ARG)
        {
            this.BasePriceLenght = BPL;
            this.ProductID = PID;
            this.AmazonRG = ARG;
            this.Name = "Name in research...";

            sea = "<span id=\"priceblock_ourprice\" class=\"a-size-medium a-color-price priceBlockBuyingPriceString\">";
            sen = "<span id=\"productTitle\" class=\"a-size-large product-title-word-break\">";
            http.DefaultRequestHeaders.Add("User-Agent", "C# program");


            searchAuto();
        }
        public void searchAuto()
        {
            search(this.BasePriceLenght, this.ProductID);
        }
        public async Task search(int BasePriceLenght, string ProductID)
        {
            var content = await http.GetStringAsync("https://www.amazon." + AmazonRG + "/dp/" + ProductID);

            ind = content.IndexOf(sea);
            MinMaxValue(int.Parse(content.Substring(ind + sea.Length, BasePriceLenght)));
            ind = content.IndexOf(sen);
            this.Name = content.Substring(ind + sen.Length, 30) + "...";
            content = null;
            GC.Collect();
        }
        public bool MinMaxValue(int p)
        {
            if (p > this.maxPrice)
            {
                this.maxPrice = p;
            }
            if (p < this.minPrice || this.minPrice == 0)
            {
                this.minPrice = p;
            }
            this.price = p;
            return true;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getProductID() 
        {
            return this.ProductID;
        }
        public int getPrice()
        {
            return this.price;
        }
        public int getMinPrice()
        {
            return this.minPrice;
        }
        public int getMaxPrice()
        {
            return this.maxPrice;
        }
    }
}
