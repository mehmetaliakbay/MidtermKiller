
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoadManager
{
    
        public static void Save(GameData gameData)
        {
        string path= Application.persistentDataPath + "/game.data"; 
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, gameData);
            }
        }
        public static GameData Load()
        {
        string path = Application.persistentDataPath + "/game.data";
        using (var fs = new FileStream(path, FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                return (GameData)formatter.Deserialize(fs);
            }
        }
    
}
