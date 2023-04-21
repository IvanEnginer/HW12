using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void Save(Progres progres)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/progress.yo";

        FileStream fileStream = new FileStream(path, FileMode.Create);

        ProgresDate progresDate = new ProgresDate(progres);

        binaryFormatter.Serialize(fileStream, progresDate);

        fileStream.Close();
    }

    public static ProgresDate Load()
    {
        string path = Application.persistentDataPath + "/progress.yo";

        if(File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);            
            ProgresDate progresDate = binaryFormatter.Deserialize(fileStream) as ProgresDate;
            fileStream.Close();
            return progresDate;
        }
        else
        {
            Debug.Log("No file");
            return null;
        }
    }

    public static void DeleteFile()
    {
        string path = Application.persistentDataPath + "/progress.yo";

        File.Delete(path);
    }
}
