namespace multifabriken_MarcusR91
{
    class Tofu
    {
        string _Volume;
        string _Seasoning;
        

        public Tofu( string volume, string seasoning)
        {
            this._Seasoning = seasoning;
            this._Volume = volume;
        }
        public string showVolume(){
            return this._Volume;
        }
        public string showSeasoning(){
            return this._Seasoning;
        }
    }
}