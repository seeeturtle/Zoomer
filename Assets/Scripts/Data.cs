using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FullSerializer;
using UnityEngine;

public class Data
{
    public List<Class> Classes => Load();
    private List<Class> _classes;
    private String fileName = "data.json";
    private String filePath => Path.Combine(Application.persistentDataPath, fileName);
    
    private List<Class> Load()
    {
        if (_classes != null) return _classes;

        if (!File.Exists(filePath))
        {
            _classes = new List<Class>();
            return _classes;
        };
        
        string text = File.ReadAllText(filePath);
        var data = new fsData();
        fsJsonParser.Parse(text, out data);
        var serializer = new fsSerializer();
        serializer.TryDeserialize(data, ref _classes);
        return _classes;
    }

    public void Save(Class input)
    {
        Classes.Add(input);
        var serializer = new fsSerializer();
        serializer.TrySerialize(Classes, out fsData data);
        var text = fsJsonPrinter.PrettyJson(data);
        File.WriteAllText(filePath, text);
    }
}

public class Class
{
    public String Name;
    public DateTime Start;
    public DateTime End;
    public String URL;
    public int Day;

    public Class(string name, DateTime start, DateTime end, string url, int day)
    {
        this.Name = name;
        this.Start = start;
        this.End = end;
        URL = url;
        this.Day = day;
    }
}
