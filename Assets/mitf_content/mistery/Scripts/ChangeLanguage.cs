using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{

    public static int myLangInt;
    public string LangStr = "Lang";

    public void Ru()
    {
        PlayerPrefs.SetString(LangStr, "RuStr");
    }

    public void Eng()
    {
        PlayerPrefs.SetString(LangStr, "EngStr");
    }

}