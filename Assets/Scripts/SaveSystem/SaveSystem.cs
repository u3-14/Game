using System.IO;
using UnityEngine;
using Unity.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    
    // bought array saving
    
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

            SkinsData data = new SkinsData(new bool[]{true, false, false, false, false});
        
            f.Serialize(s, data);
            s.Close();
            return data;
        }
    }
    
    // money saving

    public static void SaveMoney(int m)
    {
        BinaryFormatter f = new BinaryFormatter();
        
        string path = Application.persistentDataPath + "/saves/money.aboba";
        FileStream s = new FileStream(path, FileMode.Create);

        f.Serialize(s, m);
        s.Close();
    }
    
    public static int LoadMoney()
    {
        string path = Application.persistentDataPath + "/saves/money.aboba";

        if (File.Exists(path))
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.Open);
            
            int a = (int)(f.Deserialize(s));
            
            s.Close();

            return a;
        }
        else
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.Create);

            int data = 1000;
        
            f.Serialize(s, data);
            s.Close();
            return 1000;
        }
    }
    
    //selected skin id saving
    
    public static void SaveScinID(int m)
    {
        BinaryFormatter f = new BinaryFormatter();
        
        string path = Application.persistentDataPath + "/saves/ID.aboba";
        FileStream s = new FileStream(path, FileMode.Create);

        f.Serialize(s, m);
        s.Close();
    }
    
    public static int LoadScinID()
    {
        string path = Application.persistentDataPath + "/saves/ID.aboba";

        if (File.Exists(path))
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.Open);
            
            int a = (int)(f.Deserialize(s));
            
            s.Close();

            return a;
        }
        else
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.Create);

            int data = 0;
        
            f.Serialize(s, data);
            s.Close();
            return 0;
        }
    }
}
