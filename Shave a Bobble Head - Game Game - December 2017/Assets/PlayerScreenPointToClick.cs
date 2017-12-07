using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScreenPointToClick : MonoBehaviour {

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
