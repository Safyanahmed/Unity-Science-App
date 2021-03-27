using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkMarkCounter : MonoBehaviour
{

    public GameObject[] checkMarks;
    public GameObject win;
    public GameObject continueButton;

    // Start is called before the first frame update
    void Start()
    {
        continueButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int checkMarkCounter = 0;
      foreach (var mark in checkMarks)
        {
            if(mark.GetComponent<SpriteRenderer>().enabled)
               {
                checkMarkCounter++;
            }
        }

      if(checkMarkCounter == 3)
        {
            Debug.Log("Done!");
           
            win.GetComponent<Renderer>().enabled = true;
            continueButton.SetActive(true);
        }
        Debug.Log(checkMarkCounter);
    }
}
