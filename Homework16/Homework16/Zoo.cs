using System.Collections;
using System.Text.Json;

namespace Homework16
{
    public class Zoo<T> : IList<Animal> where T: Animal
    {
        private readonly List<Animal> _animals = new List<Animal>();
        public Animal this[int index]
        {
            get
            {
                return _animals[index];
            }
            set
            {
                _animals[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _animals.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Animal item)
        {
            _animals.Add(item);
        }

        public void Clear()
        {
            _animals.Clear();
        }

        public bool Contains(Animal item)
        {
            return _animals.Contains(item);
        }

        public void CopyTo(Animal[] array, int arrayIndex)
        {
            _animals.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return _animals.GetEnumerator();
        }

        public int IndexOf(Animal item)
        {
            return _animals.IndexOf(item);
        }

        public void Insert(int index, Animal item)
        {
            _animals.Insert(index, item);
        }

        public bool Remove(Animal item)
        {
            return _animals.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _animals.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _animals.GetEnumerator();
        }
    
        public void MakeAllSounds()
        {
            Console.WriteLine("-- Making All Sounds --");
            foreach (var item in _animals)
            {
                item.MakeSound();
            }
        }

        public void MoveAllAnimals()
        {
            Console.WriteLine("-- Moving All Animals --");
            foreach (var item in _animals)
            {
                item.Move();
            }
        }
        public void ShowAnimalInfos()
        {
            Console.WriteLine("-- Showing Info --");
            foreach (var item in _animals)
            {
                item.Info();
            }
        }

        public void PlayWithPets()
        {
            Console.WriteLine("-- Playing With Pets --");
            foreach (var item in _animals)
            {
                if (item is IPet pet)
                {
                    pet.Play();
                }
            }
        }

        public void LetBirdsFly()
        {
            Console.WriteLine("-- Letting Birds Fly --");
            foreach (var item in _animals)
            {
                if (item is IFlyable flyable)
                {
                    flyable.Fly();
                }
            }
        }

        public void sortByAge()
        {
            _animals.Sort((a, b) => a.Age.CompareTo(b.Age));
        }

        public void SaveToFile(string path)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(path, JsonSerializer.Serialize(_animals, options));
        }

        public void LoadFromFile(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var list = JsonSerializer.Deserialize<List<Animal>>(json, new JsonSerializerOptions
                {
                    Converters = { new AnimalConverter() }
                });
                _animals.Clear();
                if (list != null) _animals.AddRange(list);
            }
        }
    }

    public class AnimalConverter : System.Text.Json.Serialization.JsonConverter<Animal>
    {
        public override Animal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException("Custom deserialization logic needed.");
        }

        public override void Write(Utf8JsonWriter writer, Animal value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }

}