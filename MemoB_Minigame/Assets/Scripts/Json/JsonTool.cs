using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class JsonTool
{
    string jsonPath = Application.dataPath+@"Resources\Json\";
    
    public static void SaveJson()
    {
        string jsonPath = Application.dataPath + @"\Resources\Json\TestJson.json";
        List<LevelInfo> levelInfos = new List<LevelInfo>();
        levelInfos.Add(new LevelInfo());
        if (!File.Exists(jsonPath))
        {
            //File.Create(jsonPath);
            Debug.Log("Create");
        }

        string jsonStr=JsonMapper.ToJson(levelInfos);
        StreamWriter streamWriter = new StreamWriter(jsonPath);
        streamWriter.Write(jsonStr);
        streamWriter.Close();
    }

    public void ReadJson()
    {

    }
    

}
