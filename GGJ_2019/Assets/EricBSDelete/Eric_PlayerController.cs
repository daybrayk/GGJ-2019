using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Eric_PlayerController : MonoBehaviour {

    public float forwardSpeed = 10f;
    public float strafingSpeed = 7.5f;
    public float jumpSpeed = 10f;

    public float rotationSpeed = 25f;

    private Vector3 moveDir;

    private Rigidbody rb;
    private Camera cam;

    public float yawSpeed = 5f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //rb.drag = 8f;
	}
	
	// Update is called once per frame
	void Update () {
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        moveDir = Input.GetAxis("Horizontal") * strafingSpeed * transform.right + Input.GetAxis("Vertical") * forwardSpeed * transform.forward;

        rb.AddForce(moveDir);

        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jumpSpeed * Vector3.up, ForceMode.Impulse);
        }


        rotationSpeed = Input.GetAxis("Mouse X");
        //rb.AddTorque(rotationSpeed * Vector3.up);
        transform.Rotate(Vector3.up,rotationSpeed);

        if(Input.GetAxis("Horizontal") <= 0.2f && Input.GetAxis("Horizontal") >= -0.2f && Input.GetAxis("Vertical") <= 0.2f && Input.GetAxis("Vertical") >= -0.2f)
        {
            rb.velocity = Vector3.zero;
            //Debug.Log("Test");
        }


        //yawSpeed -= Input.GetAxis("Mouse Y");
        //Mathf.Clamp(yawSpeed, -5, 5);

        //cam.transform.Rotate(Vector3.right * yawSpeed);
    }
}
