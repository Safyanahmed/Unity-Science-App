using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject model;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
        
    }

    // Update is called once per frame
    void Update()
    {

        model.GetComponent<Renderer>().enabled = false;
        if(sphere1.GetComponent<Renderer>().enabled && sphere2.GetComponent<Renderer>().enabled)
        {
            float xyDist = Vector2.Distance(sphere1.transform.position, sphere2.transform.position);
            float xyzDist = Vector3.Distance(sphere1.transform.position, sphere2.transform.position);
            string debug = "x:" + sphere1.transform.position.x + " y: " + sphere1.transform.position.x
                + "     x:" + sphere2.transform.position.x + " y: " + sphere2.transform.position.x
                + "     Distance: " + xyDist; ;
            Debug.Log(debug);

            if (xyDist > 1 && xyDist < 50)
            {
                model.GetComponent<Renderer>().enabled = true;

            }
            else if (xyDist > 51)
            {
                model.GetComponent<Renderer>().enabled = false;

            }

            if (xyzDist > 1 && xyzDist < 50)
            {

                // Debug.Log("Detected xyz");
            }

        }

    }
}
