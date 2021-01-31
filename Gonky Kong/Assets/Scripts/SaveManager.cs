using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{


    public SerializedData serializedData;


    // Start is called before the first frame update
    void Start()
    {
        serializedData = new SerializedData();
    }

    

    public void SaveMyData()
    {
        //string save_JSON;
        serializedData.serialized_Score = GameData.Score;
        serializedData.serialized_HighScore = GameData.highscore;

        //save_JSON = JsonUtility.ToJson(serializedData);
        //Debug.Log(save_JSON);

        //PlayerPrefs.SetString("Data", save_JSON);

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamedata.save");
        bf.Serialize(file, serializedData);
        file.Close();
        Debug.Log(Application.persistentDataPath);
        Debug.Log("Game saved");

    }



    public void LoadData()
    {
        //string load_JSON;
        //load_JSON = PlayerPrefs.GetString("Data");
        //SerializedData serialized_load = JsonUtility.FromJson<SerializedData>(load_JSON);

        if (File.Exists(Application.persistentDataPath + "/gamedata.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamedata.save", FileMode.Open);
            SerializedData serializedLoad = (SerializedData)bf.Deserialize(file);


            if (serializedLoad != null)
            {
                GameData.Score = serializedLoad.serialized_Score;
                GameData.Score = serializedLoad.serialized_HighScore;
            }
            file.Close();
        }
    }
}
