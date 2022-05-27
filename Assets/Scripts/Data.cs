using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Data
{
    public static List<Class> Classes => Data.Load().ToList();
    private static String fileName = "data.json";
    private static String filePath = Path.Combine(Application.persistentDataPath, fileName);
    
    private static Class[] Load()
    {
        string text = File.ReadAllText(filePath);
        return JsonUtility.FromJson<Class[]>(text);
    }

    public static void Save(Class input)
    {
        Classes.Add(input);
        string text = JsonUtility.ToJson(Classes);
        File.WriteAllText(filePath, text);
    }
}

public class Class
{
    public String name;
    public DateTime start;
    public DateTime end;
    public String url;
}
