using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2 : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  - 2);
    }
    
    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    
}
