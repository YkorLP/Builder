using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour {

    public GameObject builder;
	private Builder b;

    void Start ()
    {
        b = builder.GetComponent<Builder>();
    }

	void OnCollisionStay(Collision collisionInfo)
	{
        Debug.Log("YAY");
        if (collisionInfo.gameObject.CompareTag("Building")) 
		{
			b._CanPlace = false;
		}
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Building"))
        {
            b._CanPlace = true;
        }
    }
}
