using System.Collections.Generic;

namespace Products
{
    public class Macaroon : IBakedGoods
    {
        public int? BakingTemperature { get; set; }

        public double? Price { get; set; }

        public double? Weight { get; set; }

        public string? Name { get; set; }

        public string? Filling { get; set; }
        public List<string> IngredientsList { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddFilling()
        {

        }
    }
}