using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {

    public Rigidbody contract;
    public  Text buttonText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void moveForward()
    {
        if (contract != null) { 
        contract.velocity = Vector3.left * 12f;
        Object.Destroy(contract, 2f);
        buttonText.text = "Sign Now"; }
   
    }

    /*private void callApi()
    {
       // string auth - api_key + ": "
    }*/
}
