using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour {

    public ParticleSystem spray;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startWriting()
    {
        if (!spray.isPlaying)
        {
            spray.Play();
            //this.ParticleSystem.Play();
            Debug.Log("jshdgfu");
        }
    }

    public void stopWriting()
    {
        if (spray.isPlaying)
        {
            spray.Stop();
            //this.ParticleSystem.Stop();
            Debug.Log("shbjcdie");
        }
    }
}
