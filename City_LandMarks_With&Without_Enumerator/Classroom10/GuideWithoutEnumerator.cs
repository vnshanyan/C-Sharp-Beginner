using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom10
{
    internal class GuideWithoutEnumerator
    {
        private Guid GuideId { get; set; }
        public string GuideName { get; set; }

        private int _index { get; set; }
        private List<Landmark> Landmarks { get; } = new List<Landmark>();
        public Landmark Current
        {
            get
            {
                return Landmarks[_index];
            }
        }

        public GuideWithoutEnumerator(List<Landmark> landmarks)
        {
            _index = -1;
            Landmarks = landmarks;
        }


        public bool MoveNext()
        {
            _index++;
            return _index < Landmarks.Count;
        }
    }
}
