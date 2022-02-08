using System.Collections;

namespace test0
{
    class Students : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
           yield return "item1";
           yield return "item2";
           yield return "item3";
        }
    }
}
