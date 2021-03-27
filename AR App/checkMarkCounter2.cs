using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkMarkCounter2 : MonoBehaviour
{

    public GameObject[] checkMarks;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int checkMarkCounter = 0;
      foreach (var mark in checkMarks)
        {
            if(mark.GetComponent<Renderer>().enabled)
               {
                checkMarkCounter++;
            }
        }

       
        if (checkMarkCounter == 5)
        {
            Debug.Log("Done!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Debug.Log(checkMarkCounter);
    }
}
