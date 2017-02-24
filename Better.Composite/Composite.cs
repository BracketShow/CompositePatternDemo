
using System.Collections.Generic;

namespace Better.Composite
{
    public class Composite : Component
    {
        public IEnumerable<Component> Children { get; set; }

        public void Add(Component component)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Component component)
        {
            throw new System.NotImplementedException();
        }

        public override void GetChild(int index)
        {
            throw new System.NotImplementedException();
        }

        public override void Operation()
        {
            throw new System.NotImplementedException();
        }
    }
}