using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Recoil : MonoBehaviour
{
    public float recoil = 1.0f;
    private XRGrabInteractable interactable = null;
    private Rigidbody rigidBody = null;


    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
        rigidBody = GetComponent<Rigidbody>();
    }

    public void ApplyRecoil()
    {
        rigidBody.AddRelativeForce(Vector3.right * recoil, ForceMode.Impulse);
    }
}
