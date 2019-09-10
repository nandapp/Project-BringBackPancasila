using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameControl : MonoBehaviour {

    public static GameControl control;

	// Use this for initialization
	void Awake ()
    {
		if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
	}
	
    public void save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerinfo.dat");

        PlayerData data = new PlayerData();

        bf.Serialize(file, data);
        file.Close();

    }

    public void load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);
        PlayerData data = (PlayerData)bf.Deserialize(file);
        file.Close();

    }

    [Serializable]
    class PlayerData
    {

    }

	// Update is called once per frame
	void Update () {
		
	}
}
