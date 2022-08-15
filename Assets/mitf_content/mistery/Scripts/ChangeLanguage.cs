using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{

    public static int myLangInt;
    public string RuStr = "RuStr";
    public string EngStr = "EngStr";
    public void Ru()
    {
        PlayerPrefs.SetString(RuStr, "RuStr");
    }

    public void Eng()
    {
        PlayerPrefs.SetString(EngStr, "EngStr");
    }

}