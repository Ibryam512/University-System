using System.Reflection;
using UniSystem.Data.Entities;

namespace UniSystem.Data
{
    public class DbSet<T> where T : BaseEntity, new()
    {
        private const char space = (char)32;

        private string seperation = new string('-', 30);
        private string name = new T().GetType().Name.ToLower();
        private int id = 1;

        private T[] values;
        public int Count { get; private set; }

        public T this[int index]
        { 
            get => values[index];
        }

        public DbSet()
        {
            this.values = new T[0];
            this.GetValuesFromFile();

            if (this.Count > 0)
            {
                this.id = this.values[this.Count - 1].Id + 1;
            }
        }

        public DbSet(string name) : this()
        {
            this.name = name;
        }

        public void Add(T item, bool increment = true)
        {
            item.CreationDate = DateTime.Now;
            LocalAdd(item);

            if (increment)
            {
                this.values[Count - 1].Id = id;
                id++;
            }

            string obj = ObjectToString(item);
            SaveToFile(obj);
        }

        public void Update(T item)
        {
            if (!DoesExist(item.Id))
                throw new ArgumentException($"An item with Id {item.Id} does not exists.");

            for (int i = 0; i < this.values.Length; i++)
            {
                if (values[i].Id == item.Id)
                {
                    values[i] = item;
                    break;
                }
            }

            OverwriteFile();
        }
        public void Remove(T item)
        {
            if (!DoesExist(item.Id))
                throw new ArgumentException($"An item with Id {item.Id} does not exists.");

            for (int i = 0; i < this.Count; i++)
            {
                if (values[i].Id == item.Id)
                {
                    ReduceArray(i);
                    this.Count--;
                }
            }

            OverwriteFile();
        }

        public List<T> ToList() => this.values.Where(x => x != null).ToList();

        public List<T> Where(Func<T, bool> predicate) => this.ToList().Where(predicate).ToList();

        public T SingleOrDefault(Func<T, bool> predicate) => this.ToList().SingleOrDefault(predicate);

        public bool Any(Func<T, bool> predicate) => this.ToList().Any(predicate);

        private void LocalAdd(T item)
        {
            if (DoesExist(item.Id))
                throw new ArgumentException($"An item with Id {item.Id} already exists.");

            if (this.values.Length == this.Count)
                ExtendArray();

            this.values[this.Count] = item;
            this.Count++;
        }

        private void ReduceArray(int index)
        {
            if (this.Count == 1)
            {
                this.values[0] = null;
                return;
            }

            for (int i = index; i < this.Count - 1; i++)
            {
                this.values[i] = this.values[i + 1];
            }
        }

        private void ExtendArray()
        {
            T[] newArray = new T[this.Count * 2 + 1];

            for (int i = 0; i < this.values.Length; i++)
            {
                newArray[i] = this.values[i];
            }

            this.values = newArray;
        }

        private void GetValuesFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader($"Data/{name}.txt"))
                {
                    string[] file = reader.ReadToEnd().Split(seperation, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var info in file)
                    {

                        T obj = new();
                        string[] lines = info.Split('\n');

                        foreach (var line in lines)
                        {
                            if (line == "" || line == "\r")
                            {
                                continue;
                            }
                            
                            string[] items = line.Split();
                            object value = GetValue(items[0], items[3]);

                            if (value == null)
                                throw new ArgumentException($"There is not set type {items[0]}.");

                            obj.GetType().InvokeMember(items[1],
                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                            Type.DefaultBinder, obj, new object[] { value });
                        }
                        if (obj.Id != 0)    
                            this.LocalAdd(obj);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                //do nothing
            }
            
        }

        private object GetValue(string type, string value)
        {
            value = value.Replace("(space)", " ");
            value = value.Replace("(enter)", "\n");

            switch (type)
            {
                case "System.String":
                    return value;
                case "System.Char":
                    return char.Parse(value);
                case "System.Boolean":
                    return bool.Parse(value);
                case "System.Byte":
                    return byte.Parse(value);
                case "System.SByte":
                    return sbyte.Parse(value);
                case "System.Int16":
                    return short.Parse(value);
                case "System.UInt16":
                    return ushort.Parse(value);
                case "System.Int32":
                    return int.Parse(value);
                case "System.UInt32":
                    return uint.Parse(value);
                case "System.Int64":
                    return long.Parse(value);
                case "System.UInt64":
                    return ulong.Parse(value);
                case "System.Single":
                    return float.Parse(value);
                case "System.Double":
                    return double.Parse(value);
                case "System.Decimal":
                    return decimal.Parse(value);
                case "System.DateTime":
                    return DateTime.Parse(value);
                //hardcoded
                case "UniSystem.Common.Gender":
                    return Enum.Parse(typeof(Common.Gender), value);
                case "UniSystem.Common.Role":
                    return Enum.Parse(typeof(Common.Role), value);
                default: return null;
            }
        }

        private void SaveToFile(string obj)
        {
            using (StreamWriter writer = new StreamWriter($"Data/{name}.txt", true))
            {
                writer.WriteLine(obj); 
            }
        }

        private void OverwriteFile()
        {
            using (StreamWriter writer = new StreamWriter($"Data/{name}.txt"))
            {
                for (int i = 0; i < this.Count; i++)
                {
                    string obj = ObjectToString(values[i]);
                    writer.WriteLine(obj);
                }
            }
        }

        private string ObjectToString(T item)
        {
            var info = item.GetType().GetProperties();
            string obj = "";

            foreach (var prop in info)
            {
                string value = prop.GetValue(item).ToString();
                value = value.Replace(" ", "(space)");
                value = value.Replace(Environment.NewLine, "(enter)");

                obj += $"{prop.PropertyType} {prop.Name} = {value}\n";
            }

            obj += seperation;

            return obj;
        }

        private bool DoesExist(int id)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (values[i].Id == id)
                    return true;
            }

            return false;
        }
    }
}
