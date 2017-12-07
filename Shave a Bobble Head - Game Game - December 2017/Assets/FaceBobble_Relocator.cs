using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBobble_Relocator : MonoBehaviour {
    public Transform faceToRelocate;
	// Use this for initialization
	void Start () {
        if(faceToRelocate == null)
        {
            //Transform[] children = transform.GetChild;
            //foreach(Transform child in transform.children)
            Debug.LogError("If the Face transform is not present, the game can not return face to origin location!");
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction_pos = transform.position - faceToRelocate.transform.position;
        Vector3 direction_rot = transform.rotation.eulerAngles - faceToRelocate.transform.rotation.eulerAngles;

        //targetDirection = target.position - transform.position; // Save direction
        //distance = targetDirection.magnitude; // Find distance between this object and target object
        //targetDirection = targetDirection.normalized; // Normalize target direction vector

        //if (distance < radius)
        //{
        //    rb.AddForce(targetDirection * forceAmount * Time.deltaTime);
        //}
    }
}
