namespace zad1
{
    class Result
    {
        public List<int> itemsInside = [];
        public int sumWeight;
        public int sumValue;

        public override string ToString()
        {
            string resultLine = "";

            resultLine += "items inside: ";

            for (int i = 0; i < itemsInside.Count; ++i)
            {
                resultLine += $"{itemsInside[i]} ";
            }

            resultLine += $"\ntotal value: {sumValue}\ntotal weight: {sumWeight}";

            return resultLine;
        }

    }
}
