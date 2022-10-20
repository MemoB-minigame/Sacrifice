using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System;
using UnityEditor.VersionControl;
using System.Threading;

public class AssetBuild : ScriptableObject
{
    [MenuItem("Tools/Excel/CreateLevelAsset")]
    public static void CreatLevelAsset()
    {
        LevelManager manager = ScriptableObject.CreateInstance<LevelManager>();
        
        manager.levelInfo = ExcelTool.CreateLevelAsset(ExcelReadConfig.excelFolderPath + "LevelInfo.xlsx");

        
        string assetPath = ($"{ExcelReadConfig.assetPath}{"Item"}.asset");
        if (!Directory.Exists(ExcelReadConfig.assetPath))
        {
            Directory.CreateDirectory(ExcelReadConfig.assetPath);
        }
        if (File.Exists(assetPath))
        {
            AssetDatabase.DeleteAsset(assetPath);
            //File.Delete(assetPath);
            //File.Delete(assetPath + ".meta");
            //Thread.Sleep(3000);
        }

        
        AssetDatabase.CreateAsset(manager, assetPath);
        //var item = AssetDatabase.LoadAssetAtPath<LevelManager>(assetPath);
        //EditorUtility.SetDirty(item);
        //AssetDatabase.SaveAssetIfDirty(item);
        
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        
    }
}
