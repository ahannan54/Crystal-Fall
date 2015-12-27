using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

    public GameObject pooledobject;
    public int pooledvalue;
    List<GameObject> pooledobjects;
	// Use this for initialization
	void Start () {

        pooledobjects = new List<GameObject>();

        for (int i = 0; i < pooledvalue; i++)
        {
            GameObject obj = new GameObject();
            obj = (GameObject)Instantiate(pooledobject);
            obj.SetActive(false);

            pooledobjects.Add(obj);
        }

	}

    public GameObject getgameobject()
    {
        for (int i = 0; i < pooledobjects.Count; i++)
        {
            if (!pooledobjects[i].activeInHierarchy)
            {
                return pooledobjects[i];
            }
        }

        GameObject obj = new GameObject();
        obj = (GameObject)Instantiate(pooledobject);
        obj.SetActive(false);

        return obj;

    }
}
