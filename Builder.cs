using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour 
{
	public Transform _object;
	public Transform previewObject;
    public Transform placeEffect;

    //public Transform placePoint;

    //public Transform rotatePoint;

    public LayerMask hitLayers;

    public bool _CanPlace = true;
    public bool bugReporterOpen;

    void Start ()
    {
       //rotatePoint = previewObject.gameObject.transform.GetChild(0);
    }

	void Update()
	{
		Vector3 mouse = Input.mousePosition;
		Ray castPoint = Camera.main.ScreenPointToRay(mouse);
		RaycastHit hit;
		if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
		{
			_object.transform.position = hit.point + _object.transform.localScale.y/2 * hit.normal;
		}

		if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
		{
			previewObject.transform.position = new Vector3( Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y) + 0.25f, Mathf.RoundToInt(hit.point.z));
        }

		if (Input.GetMouseButtonDown(0) && _CanPlace == true && bugReporterOpen == false)
		{
            Instantiate(_object, previewObject.transform.position, previewObject.transform.rotation);
           // Instantiate(placeEffect, previewObject.transform.position, previewObject.transform.rotation);
        }
	
		if (Input.GetMouseButtonDown(1))
		{
            previewObject.transform.RotateAround(Vector3.zero, Vector3.up, 90);
        }
	}
}
