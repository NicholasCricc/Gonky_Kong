using System.Collections;
using System.Collections.Generic;
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
        string save_JSON;
        serializedData.serialized_Score = GameData.Score;

        save_JSON = JsonUtility.ToJson(serializedData);
        Debug.Log(save_JSON);

        PlayerPrefs.SetString("Data", save_JSON);

    }



    public void LoadData()
    {
        string load_JSON;
        load_JSON = PlayerPrefs.GetString("Data");
        SerializedData serialized_load = JsonUtility.FromJson<SerializedData>(load_JSON);

        if (serialized_load != null)
        {
            GameData.Score = serialized_load.serialized_Score;
        }


    }
}
