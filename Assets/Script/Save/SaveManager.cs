// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.IO;
// using System.Runtime.Serialization.Formatters.Binary;

// public static class SaveManager
// {
    
//     private static string filePath = Path.Combine(Application.persistentDataPath, "MySaveFile.dat");
    
//     public static void Save(GameData data, string fileName)
//     {
//         string filePath = Path.Combine(Application.persistentDataPath, fileName + ".dat");
//         BinaryFormatter formatter = new BinaryFormatter();
//         FileStream stream = new FileStream(filePath, FileMode.Create);

//         formatter.Serialize(stream, data);
//         stream.Close();
//     }

//     public static GameData Load(string fileName)
//     {
//         string filePath = Path.Combine(Application.persistentDataPath, fileName + ".dat");
//         if (File.Exists(filePath))
//         {
//             BinaryFormatter formatter = new BinaryFormatter();
//             FileStream stream = new FileStream(filePath, FileMode.Open);

//             GameData data = (GameData)formatter.Deserialize(stream);
//             stream.Close();
//             return data;
//         }
//         else
//         {
//             Debug.LogError("Save file not found in " + filePath);
//             return new GameData();
//         }
//     }
// }