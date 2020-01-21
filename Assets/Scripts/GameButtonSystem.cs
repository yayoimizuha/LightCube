using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonSystem : MonoBehaviour
{
    public void GameMenu () {
        SceneManager.LoadScene("Menu");
	}

    public void Single () {
        SceneManager.LoadScene("SProject");
	}

    public void Multi () {
        SceneManager.LoadScene("MProject");
	}
    public void EndGame() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
