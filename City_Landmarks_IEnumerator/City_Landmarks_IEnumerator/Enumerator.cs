using System.Collections;

namespace Guide_City_Landmarks
{
    public class Enumerator : IEnumerator<Landmark>
    {
        private int currentIndex = -1;
        private readonly List<Landmark> landmarks;

        public Enumerator(List<Landmark> landmarks)
        {
            this.landmarks = landmarks;
        }

        public Landmark Current { get { return landmarks[currentIndex]; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < landmarks.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
