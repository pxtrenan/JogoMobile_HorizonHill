using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionMethods : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void FindAndSetActive (string name, System.Type type, bool status)
    {
        var objs = Resources.FindObjectsOfTypeAll(type);

        foreach (GameObject obj in objs)
        {
            if (obj.name == name)
            {
                obj.SetActive(status);
            }
        }
    }
}
