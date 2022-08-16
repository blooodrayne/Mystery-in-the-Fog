using System.Linq;
using Fungus;
using UnityEngine;


public class SetLanguage : MonoBehaviour
{
    [SerializeField] private Flowchart _flowchart;
   private const string StrForLook = "Lang";
   // private string LangStrforLook = PlayerPrefs.GetString(StrForLook);

    // private const string EngStr = "EngStr";
    public void Start()
    {
        GetLanguageFromPrefs();
    }
    private void GetLanguageFromPrefs()
    {

        foreach (var flowchartVariable in _flowchart.Variables.Where(flowchartVariable => flowchartVariable.Key.Contains("Language")))
        {
            // зык выбирается исходя из ключа
             switch (PlayerPrefs.GetString(StrForLook))
            {

                case "EngStr":
                    flowchartVariable.Apply(SetOperator.Assign, true);
                    break;

                case "RuStr":
                    flowchartVariable.Apply(SetOperator.Assign, false);
                    break;
               
            }
            


            /*if (PlayerPrefs.HasKey(RuStr))
                flowchartVariable.Apply(SetOperator.Assign, false);
            else if (PlayerPrefs.HasKey(EngStr))
                flowchartVariable.Apply(SetOperator.Assign, true);*/
        }
    }
}

