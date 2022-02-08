using System.Collections;
using System.Collections.Generic;

namespace test0
{
    public class Teachers:IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "item1";
            yield return "item2";
            yield return "item3";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

        
    }
}
