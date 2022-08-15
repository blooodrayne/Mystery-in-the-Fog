using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{

    public static int myLangInt;
    public string RuStr = "Ru";
    public string EngStr = "Eng";
    public void Ru()
    {
        PlayerPrefs.SetString(RuStr, "Standart");
    }

    public void Eng()
    {
        PlayerPrefs.SetString(EngStr, "English");
    }

}
