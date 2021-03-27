using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkMarkCounter2 : MonoBehaviour
{

    public GameObject[] checkMarks;
    public GameObject win;

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
            if(mark.GetComponent<SpriteRenderer>().enabled)
               {
                checkMarkCounter++;
            }
        }
        
        if (checkMarkCounter == 5)
        {
            Debug.Log("Done!");
            win.GetComponent<Renderer>().enabled = true;
        }
        Debug.Log(checkMarkCounter);
    }
}
