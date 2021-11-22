namespace multifabriken_MarcusR91
{
    class Godis
    {
        string _Flavor;
        string _Quantity;

        public Godis(string quantity, string flavor)
        {
            this._Flavor = flavor;
            this._Quantity = quantity;
        }
        public string showQuantity(){
            return this._Quantity;
        }
         public string showFlavor(){
            return this._Flavor;
        }
    }
}