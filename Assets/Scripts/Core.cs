using UnityEngine;

public static class Core
{
    public static UI UI;
    public static Data Data;
    public static Right Right;

    public static void Load()
    {
        UI = new UI(Object.FindObjectOfType<UI_Reference>());
        Data = new Data();
        Right = new Right();
    }
}
