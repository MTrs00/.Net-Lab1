using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestZad1"), InternalsVisibleTo("GUI")]

namespace zad1
{
    class Problem
    {
        public int itemNumber;

        public List<Przedmiot> items = [];


        public Problem(int ItemNumber, int seed)
        {

            Random random = new Random(seed);

            itemNumber = ItemNumber;
            int newValue;
            int newWeight;

            for (int i = 0; i < itemNumber; ++i)
            {
                newValue = random.Next(1, 11);
                newWeight = random.Next(1, 11);

                items.Add(new Przedmiot(i, newWeight, newValue));
            }
        }


        public override string ToString()
        {
            string line;
            string resultLine = "";

            for (int i = 0; i < itemNumber; ++i)
            {
                line = $"no.: {items[i].number}     v: {items[i].value}     w: {items[i].weight}    vtw: {items[i].valueToWeight}";
                resultLine = resultLine + line;
      
            }

            return resultLine;
        }

        public Result Solve(int capacity)
        {
            Result result = new Result();
            var sorted = items.OrderByDescending(o => o.valueToWeight).ToList();
            // o => o.valueToWeight to wyrażenie lambda, które określa, po jakiej właściwości ma odbywać się sortowanie.


            int storage = 0;

            for (int j = 0; j < itemNumber; ++j)
            {
                if (sorted[j].weight <= capacity - storage)
                {
                    result.itemsInside.Add(sorted[j].number);
                    result.sumValue += sorted[j].value;
                    result.sumWeight += sorted[j].weight;
                    storage += sorted[j].weight;
                }
                if (storage == capacity)
                    break;
            }
            return result;
        }
    }
}
