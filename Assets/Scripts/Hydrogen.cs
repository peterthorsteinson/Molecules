using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip audioClipBallBounce;

    GameObject partner = null;
    SpringJoint springJoint;

    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (partner == null && other.gameObject.CompareTag("Hydrogen"))
        {
            Hydrogen otherHydrogen = (Hydrogen)other.gameObject.GetComponent("Hydrogen");

            if (otherHydrogen.partner == null) // two free radicals meet and form covalent bond
            {
                partner = other.gameObject;
                otherHydrogen.partner = this.gameObject;

                // chemical bond formation suddenly pulls slightly closer together
                float deltaX = partner.transform.position.x - this.transform.position.x;
                float deltaY = partner.transform.position.y - this.transform.position.y;
                float deltaZ = partner.transform.position.z - this.transform.position.z;
                this.transform.position = new Vector3(
                    this.transform.position.x + 0.25f * deltaX,
                    this.transform.position.y + 0.25f * deltaY,
                    this.transform.position.z + 0.25f * deltaZ);
                partner.transform.position = new Vector3(
                    partner.transform.position.x - 0.25f * deltaX,
                    partner.transform.position.y - 0.25f * deltaY,
                    partner.transform.position.z - 0.25f * deltaZ);

                // create SpringJoint to implement covalent bond between these two atoms
                springJoint = this.gameObject.AddComponent<SpringJoint>();
                springJoint.connectedBody = other.gameObject.GetComponent<Rigidbody>();
                springJoint.anchor = new Vector3(0, 0, 0);
                springJoint.connectedAnchor = new Vector3(0, 0, 0);
                springJoint.spring = 10;
                springJoint.minDistance = 0.0f;
                springJoint.maxDistance = 0.0f;
                springJoint.tolerance = 0.025f;
                springJoint.breakForce = Mathf.Infinity;
                springJoint.breakTorque = Mathf.Infinity;
                springJoint.enableCollision = false;
                springJoint.enablePreprocessing = true;
            }
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            audioSource.PlayOneShot(audioClipBallBounce, 0.25f);
        }
    }

}
