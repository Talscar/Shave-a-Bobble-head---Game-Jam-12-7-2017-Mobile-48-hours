using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairScore : MonoBehaviour {
    public int hairCutValue;
    //public bool canCut;
    public GameObject ParticleEmmiter;
    [SerializeField] private float ParticleEmmiter_LifeTime;

    void Start()
    {
        ParticleSystem particleSystem_New = ParticleEmmiter.GetComponent<ParticleSystem>();
        ParticleEmmiter_LifeTime = (particleSystem_New.duration + particleSystem_New.startLifetime); //May require a percent variable.
    }

    void OnDestroy()
    {
        GameObject newParticle = Instantiate(ParticleEmmiter, transform.position, transform.rotation);
        Destroy(newParticle, ParticleEmmiter_LifeTime);
    }

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
