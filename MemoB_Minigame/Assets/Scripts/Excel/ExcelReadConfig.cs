using Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine;

public class ExcelReadConfig
{
    //excel文件存放在Assets/Excel中
    public static readonly string excelFolderPath = Application.dataPath + "/Excel/";

    public static readonly string assetPath = "Assets/Resources/DataAssets/" ;

}

public class ExcelTool
{
    public static LevelInfo CreateLevelAsset(string filePath)
    {
        int row = 0,column=0;
        LevelInfo levelInfo = new LevelInfo();
        
        DataRowCollection collect=ReadExcel(filePath,ref column,ref row);
        //把数据读到collect里面！
        levelInfo.layout.Height = 5;

        return levelInfo; 
        
    }
    //获取excel中的内容
    static DataRowCollection ReadExcel(string filePath,ref int column,ref int row)
    {
        FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader excelReader=ExcelReaderFactory.CreateOpenXmlReader(fileStream);

        DataSet result = excelReader.AsDataSet();
        column = result.Tables[0].Columns.Count;
        row = result.Tables[0].Rows.Count;

        return result.Tables[0].Rows;
    }
}