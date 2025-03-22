namespace zad1
{
    class Przedmiot
    {
        public bool inside;
        public int weight;
        public int value;
        public float valueToWeight;
        public int number;

        public Przedmiot(int Number, int Weight, int Value)
        {
            number = Number;
            inside = false;
            weight = Weight;
            value = Value;
            valueToWeight = (float)value / (float)weight;
        }

        public override string ToString()
        {
            return $"v: {value} w: {weight}";
        }
    }
}
