using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Throwable : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.AddListener(EventTriggerType.PointerDown, Hold);
        gameObject.AddListener(EventTriggerType.PointerUp, Release);
    }

    public void Hold()
    {
        // get the Transform component of the pointer
        Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;

        // set the GameObject's parent to the pointer
        transform.SetParent(pointerTransform, false);

        // position it in the view
        transform.localPosition = new Vector3(0, 0, 3);

        // disable physics
        GetComponent<Rigidbody>().isKinematic = true;
    }

    public void Release()
    {
        // set the parent to the world
        transform.SetParent(null, true);

        // get the rigidbody physics component
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // reset velocity
        rigidbody.velocity = Vector3.zero;

        // enable physics
        rigidbody.isKinematic = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
