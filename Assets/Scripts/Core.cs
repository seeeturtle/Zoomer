using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Core
{
    public static UI UI;
    public static Data Data;

    public static void Load()
    {
        UI = new UI(Object.FindObjectOfType<UI_Reference>());
        Data = new Data();
    }
}
