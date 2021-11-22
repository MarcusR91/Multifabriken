namespace multifabriken_MarcusR91
{
    class Snöre
    {
        string _stringColor;
        string _length;

        public Snöre(string stringColor, string length)
        {
            this._stringColor = stringColor;
            this._length = length;
        }
        public string showStringColor(){
            return this._stringColor;
        }
        public string showStringLength(){
            return this._length;
        }

    }
}