using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    public class RangedColorCollection : ColorDefinition, IEnumerable<RangedColor>
    {
        private readonly IEnumerable<RangedColor> _colorRanges;
        public RangedColorCollection(IEnumerable<RangedColor> colorRanges) 
        {
            _colorRanges = colorRanges;
        }

        public IEnumerator<RangedColor> GetEnumerator()
        {
            return _colorRanges.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
