using System.IO;
using UnityEngine;
using Unity.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    public static void SaveBuyingArray(bool[] a)
    {
        BinaryFormatter f = new BinaryFormatter();
        
        string path = Application.persistentDataPath + "/saves/boughtSkins.aboba";
        FileStream s = new FileStream(path, FileMode.Create);

        SkinsData data = new SkinsData(a);
        
        f.Serialize(s, data);
        s.Close();
    }

    public static SkinsData LoadBuyingArray()
    {
        string path = Application.persistentDataPath + "/saves/boughtSkins.aboba";

        if (File.Exists(path))
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.Open);
            
            SkinsData data = f.Deserialize(s) as SkinsData;
            
            s.Close();

            return data;
        }
        else
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.Create);

            SkinsData data = new SkinsData(new bool[]{false});
        
            f.Serialize(s, data);
            s.Close();
            return null;
        }
    }
    
}
