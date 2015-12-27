using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

    public GameObject destructionpoint;

	// Use this for initialization
	void Start () {

        destructionpoint = GameObject.Find("DestructionPoint");
	
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y > destructionpoint.transform.position.y)
        {
            gameObject.SetActive(false);
        }
	
	}
}
