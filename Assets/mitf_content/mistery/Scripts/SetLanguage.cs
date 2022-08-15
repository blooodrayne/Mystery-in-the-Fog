using System.Linq;
using Fungus;
using UnityEngine;


    public class SetLanguage : MonoBehaviour
    {
        [SerializeField] private Flowchart _flowchart;
        private const string RuStr = "Ru";
        private const string EngStr = "Eng";
        public void Start()
        {
            GetLanguageFromPrefs();
        }
        private void GetLanguageFromPrefs()
        {
            foreach (var flowchartVariable in _flowchart.Variables.Where(flowchartVariable => flowchartVariable.Key.Contains("Language")))
            {
                switch (PlayerPrefs.GetString(RuStr))
                {
                    case RuStr:
                        flowchartVariable.Apply(SetOperator.Assign, false);
                        break;
                    case EngStr:
                        flowchartVariable.Apply(SetOperator.Assign, true);
                        break;
                }
            }
        }
    }


