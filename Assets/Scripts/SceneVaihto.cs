using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneVaihto : MonoBehaviour
{

   
    public void SceneLoad(string scene)
    {
        SceneManager.LoadScene(scene,LoadSceneMode.Single);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("Labyrintti", LoadSceneMode.Single);
        }
    }
}
