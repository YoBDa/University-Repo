using System;
using System.Collections.Generic;
using System.Drawing;
using CsvHelper;
using System.IO;
using System.Windows.Forms;

namespace HashTable
{
    public enum KeysType { name,phone,birthdate }
    public delegate int HashFunction(string Key);
    public class MyHashTable
    {
        private HashFunction HashFunc;
        private KeysType KeyType;
        private int RowCount;
        private List<User>[] Table;
        private int maxCount;  
        public int Length
        {
            get
            {
                return Table.Length;
            }
        }

        public MyHashTable(int RowCount, KeysType KeyType, HashFunction hashfunc)
        {
            this.RowCount = RowCount;
            this.KeyType = KeyType;
            this.HashFunc = hashfunc;
            Table = new List<User>[RowCount];
            for (int i = 0; i < Table.Length; i++)
                Table[i] = new List<User>();
        }

        long map(long x, long in_min, long in_max, long out_min, long out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
        public void Draw(Graphics gr, int Width, int Height)
        {
            int lineWidth = Height / RowCount;
            int y = 0;

            foreach (var users in Table) {
                if (users == null) continue;
                SolidBrush br = new SolidBrush(Color.Green);
                Pen pen = new Pen(br, lineWidth);
                gr.DrawLine(pen, 0, y, map(users.Count, 0, maxCount, 0, Width), y);
                y += lineWidth;
                
            }

            gr.DrawLine(Pens.Black, 0, Height - 30, 0, Height - 15);
            gr.DrawLine(Pens.Black, Width-2, Height - 30, Width-2, Height - 15);
            gr.DrawString("0", SystemFonts.DefaultFont, Brushes.Black, 0, Height-15);
            gr.DrawString($"{maxCount}", SystemFonts.DefaultFont, Brushes.Black, Width-40, Height-15);

        }

        public User Find(string Key, out int StepCount)
        {
            StepCount = 0;
            if (Table == null || Table.Length == 0) return null;
            int hash = HashFunc.Invoke(Key) % RowCount;
            List<User> users = Table[hash];
            //if (users.Count == 0) throw new ArgumentNullException();
            
            foreach (var user in users)
            {
                StepCount++;
                string foundKey = "";
                switch (KeyType)
                {
                    case KeysType.name:
                        foundKey = user.Name;
                        break;
                    case KeysType.phone:
                        foundKey = user.Phone;
                        break;
                    default:
                        foundKey = user.BirthDate;
                        break;
                }
                if (Key == foundKey)
                    return user;
            }

            return null;
        }

        public void Load()
        {
            List<User> users = new List<User>();
            string filename = "People.txt";
            using (TextReader streamReader = new StreamReader(filename))
            {
                CsvHelper.Configuration.CsvConfiguration cfg = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture);
                cfg.HeaderValidated = null;
                cfg.Delimiter = ";";
                using (CsvReader csvReader = new CsvReader(streamReader, cfg))
                {
                    var data = csvReader.GetRecords<User>();
                    users.AddRange(data);
                    foreach (User user in users)
                    {
                        switch (KeyType)
                        {
                            case KeysType.name:
                                Table[HashFunc.Invoke(user.Name) % RowCount].Add(user);
                                break;
                            case KeysType.phone:
                                Table[HashFunc.Invoke(user.Phone) % RowCount].Add(user);
                                break;
                            default:
                                Table[HashFunc.Invoke(user.BirthDate) % RowCount].Add(user);
                                break;

                        }

                    }
                }
                foreach (var list in Table)
                    if (maxCount < list.Count)
                        maxCount = list.Count;
            }



        }


    }
}
