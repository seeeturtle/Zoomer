using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.PlayerLoop;
using static UnityEngine.Application;

public class Right
{
    private ExistState exist;

    public Right()
    {
        exist = new UnExist();
    }

    public void OnGo()
    {
        exist.OnGo();
    }

    public void Update()
    {
        exist = exist.Update();
    }
}

//
// public class FakeRight : Right
// {
//     public new double Calculate()
//     {
//         Debug.Log("calculating");
//         return 1;
//     }
//
//     public new string URL => "https://google.com";
//     public new string Name => "New Class";
//     public new bool Exists => true;
// }