using zad1;

namespace TestZad1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void IsFittingTest()
        {
            Random random = new Random();
            Result result = new Result(); 

            Problem problem = new Problem(50, random.Next());
            result = problem.Solve(40);

            bool fittingItem = false;
            

            for(int i=0; i<50; ++i)
            {
                if (problem.items[i].weight <= 40)
                {
                    fittingItem = true;
                    break;
                }
            }
            // Jest przedmiot ktory sie zmiesci a plecak jest pusty
            Assert.IsFalse(fittingItem && result.sumWeight == 0);

            // Nie ma przedmiotu ktory sie zmiesci a plecak nie jest pusty
            Assert.IsFalse(!fittingItem && result.sumWeight != 0);
        }

        [TestMethod]
        public void TestKonkretnejInstancji()
        {
            Problem problem = new Problem(10, 1);
            Result result = new Result();

            result = problem.Solve(10);

            Assert.IsTrue(result.itemsInside[0] == 0 && result.itemsInside[1] == 2 && result.itemsInside[2] == 5);

        }


        [TestMethod]
        public void noMoreFittingItem()
        {
            Random random = new Random();
            Result result = new Result();

            Problem problem = new Problem(50, random.Next());
            result = problem.Solve(40);

            bool isInside = false;
            int remainingWeight = 40 - result.sumWeight;

            for(int i = 0; i<50; ++i)
            {
                for(int j=0; j<result.itemsInside.Count; ++j)
                {
                    if (problem.items[i].number == result.itemsInside[j])
                    {
                        isInside = true;
                        break;
                    }
                    else
                        isInside = false;
                }
                Assert.IsFalse(problem.items[i].weight < remainingWeight && !isInside);
            }

        }

        [TestMethod]
        public void noRepeatingItems()
        {
            Random random = new Random();
            Result result = new Result();

            Problem problem = new Problem(50, random.Next());
            result = problem.Solve(40);


            for(int i=0; i<result.itemsInside.Count; ++i)
            {
                for(int j=0; j<result.itemsInside.Count; ++j)
                {
                    Assert.IsFalse(result.itemsInside[i] == result.itemsInside[j] && i != j);
                }
            }

        }

    }
}
