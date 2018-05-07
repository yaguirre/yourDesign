using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

    public Transform vrCamera;
    public float speedWalk = 30.0f;
    private CharacterController caractercito;

    // Use this for initialization
    void Start(){
        caractercito = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
        if(GvrControllerInput.ClickButtonUp){
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                caractercito.SimpleMove(forward * speedWalk);
        }
    }
}
