using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataLoader
{
    private string _path = "BattleTurn.json";
    public readonly BattleTurn BattleTurn;

    public DataLoader()
    {
        string json = File.ReadAllText(Application.streamingAssetsPath + "/" + _path);
        if (json == null)
            Debug.LogError("File is emty");
        BattleTurn = JsonUtility.FromJson<BattleTurn>(json);
    }
}
