using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    // public Scene scene1;
    // [SerializeField] protected Scene scene = new Scene();
    // [Tooltip("The ExecuteLua command adds a global Lua variable with this name bound to the flowchart prior to executing.")]
    // [SerializeField] protected Scene scene;

    // Start is called before the first frame update
    public void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGame()
    {
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Game"));
        //  SceneManager.SetActiveScene(SceneManager.GetSceneByPath("Assets/Scenes/Game.unity"));
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);
    }
}
