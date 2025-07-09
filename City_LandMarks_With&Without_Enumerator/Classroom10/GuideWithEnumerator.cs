using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom10
{
    internal class GuideWithEnumerator : IEnumerator<Landmark>
    {
        private readonly List<Landmark> _landmarks;
        private int _index = -1;
        public GuideWithEnumerator(List<Landmark> landmarks)
        {
            _landmarks = landmarks;
        }
        public Landmark Current
        {
            get { return _landmarks[_index]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _index++;
            return _landmarks.Count > _index;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
