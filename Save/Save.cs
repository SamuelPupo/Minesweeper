using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Save
{
    /// <summary>
    /// The Save class has the function of save/load the data of the records of the game.
    /// </summary>
    public class Save
    {
        private static readonly IFormatter Text = new BinaryFormatter();
        private static Stream _save;

        /// <summary>
        /// It evaluates if the player made a new Record.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static bool Record(string level, int time)
        {
            var data = Data();
            switch (level)
            {
                case "Novice":
                    return time < int.Parse(data[1]);
                case "Intermediate":
                    return time < int.Parse(data[3]);
                case "Expert":
                    return time < int.Parse(data[5]);
                default:
                    return false;
            }
        }

        /// <summary>
        /// It Serialize the Save of the new Record.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="time"></param>
        public static void Serialize(string name, string level, int time)
        {
            var data = Data();
            switch (level)
            {
                case "Novice":
                    if (time >= int.Parse(data[1]))
                        return;
                    data[0] = name;
                    data[1] = time.ToString();
                    break;
                case "Intermediate":
                    if (time >= int.Parse(data[3]))
                        return;
                    data[2] = name;
                    data[3] = time.ToString();
                    break;
                case "Expert":
                    if (time >= int.Parse(data[5]))
                        return;
                    data[4] = name;
                    data[5] = time.ToString();
                    break;
                default:
                    return;
            }
            _save = new FileStream("Save.bin", FileMode.Open, FileAccess.Write);
            var newData = data.Aggregate("", (current, item) => current + (item + '\n'));
            Text.Serialize(_save, newData);
            _save.Close();
        }

        /// <summary>
        /// It returns the processed Save of the Records. If the Save are corrupted, it resets them.
        /// </summary>
        /// <returns></returns>
        public static List<string> Data()
        {
            string deserialize;
            try
            {
                _save = new FileStream("Save.bin", FileMode.Open, FileAccess.Read);
                deserialize = Text.Deserialize(_save).ToString();
                _save.Close();
            }
            catch (Exception)
            {
                _save?.Close();
                _save = new FileStream("Save.bin", FileMode.Create, FileAccess.Write);
                deserialize = "Anonymous" + "\n" + "99999" + "\n" + "Anonymous" + "\n" + "99999" + "\n" + "Anonymous" +
                              "\n" + "99999" + "\n";
                Text.Serialize(_save, deserialize);
                _save.Close();
            }
            var data = new List<string>();
            var separate = "";
            foreach (var x in deserialize)
            {
                if (x == '\n')
                {
                    data.Add(separate);
                    separate = "";
                }
                else
                    separate += x;
            }
            return data;
        }
        
        /// <summary>
        /// It Reset the Save of the Records.
        /// </summary>
        /// <param name="level"></param>
        public static void Reset(string level)
        {
            var data = Data();
            switch (level)
            {
                case "All":
                    data[0] = "Anonymous";
                    data[1] = "99999";
                    data[2] = "Anonymous";
                    data[3] = "99999";
                    data[4] = "Anonymous";
                    data[5] = "99999";
                    break;
                case "Novice":
                    data[0] = "Anonymous";
                    data[1] = "99999";
                    break;
                case "Intermediate":
                    data[2] = "Anonymous";
                    data[3] = "99999";
                    break;
                case "Expert":
                    data[4] = "Anonymous";
                    data[5] = "99999";
                    break;
                default:
                    return;
            }
            _save = new FileStream("Save.bin", FileMode.Open, FileAccess.Write);
            var newData = data.Aggregate("", (current, item) => current + (item + '\n'));
            Text.Serialize(_save, newData);
            _save.Close();
        }
    }
}
