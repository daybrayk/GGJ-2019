using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject projectile;
    public float launchSpeed = 1530f;
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetButton("Fire1"))
        {
            GameObject temp = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            temp.GetComponent<Rigidbody>().AddForce(launchSpeed * Vector3.forward,ForceMode.Impulse);
            Destroy(temp, 2f);
        }

	}
}
