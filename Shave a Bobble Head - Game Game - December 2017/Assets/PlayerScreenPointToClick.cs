using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScreenPointToClick : MonoBehaviour {

    /// <summary>
    /// Score keeping will gather the score for storing variables of the name, the time if on a time run. Points based on difficulty of the facial hairs to cut.
    /// Hairs cut to say how many you did successfully. Unsuccessful_hairsCut to score how many you failed to cut. facesDone to count faces completed or attempted!
    /// facesSkipped to count the faces you did not do.
    /// </summary>
    [System.Serializable]
    public struct scoreKeeping
    {
        [SerializeField] public string player_Name;
        [SerializeField] public int time;
        [SerializeField] public int points;
        [SerializeField] public int Successful_hairsCut;
        [SerializeField] public int Unsuccessful_hairsCut;
        [SerializeField] public int facesDone;
        [SerializeField] public int facesSkipped;
    }
    [SerializeField] public scoreKeeping myScore;
    /* Keep score of hairs cut and get value from the head
     * 
     * 
     * If i am clicking a mouse, or touching a screen on a mobile device screenPointRaycast to location 
     * If it hits hair knock it off and send a message
     * If it hits the face stop the ray, hit it with the force of speed and direction and bopple the head in a direction
     * 
     */

    public Camera cam;

    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        //Ray ray = cam.ScreenPointToRay(new Vector3(200, 200, 0));
        //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);

        if (Input.GetButton("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(ray.origin, ray.direction * 10, Color.cyan);
                Debug.Log("Before destroying thing");
                if (hit.collider.gameObject.tag == "facialHair")
                {
                    Debug.Log("Destroy thing");
                    GameObject destroy = hit.collider.gameObject;
                    Destroy(destroy);
                }
            }
                //Instantiate(particle, transform.position, transform.rotation);
        }
    }
}
