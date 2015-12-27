using UnityEngine;
using System.Collections;

public class teller : MonoBehaviour {

    public GameObject spike;
    public Transform object1;

    public ObjectPooler[] objclasses;
    public float distancebw;

    //public GameObject[] spikes;
    private int spikeselector;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (object1.transform.position.y > transform.position.y)
        {
            object1.transform.position = new Vector3(transform.position.x, transform.position.y - distancebw , transform.position.z);

            spikeselector = Random.Range(0, objclasses.Length);

            //Instantiate(objclasses[spikeselector], object1.position, object1.rotation);


            GameObject spike = objclasses[spikeselector].getgameobject();

            spike.transform.position = transform.position;
            spike.transform.rotation = transform.rotation;

            spike.SetActive(true);
        }

	}
}
