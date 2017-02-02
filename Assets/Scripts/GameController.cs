using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Hydrogen hydrogenPrefab;
    public List<Hydrogen> hydrogens = new List<Hydrogen>();

    // Use this for initialization
    void Start () {
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        foreach (Hydrogen hydrogen in hydrogens)
        {
            hydrogen.GetComponent<Rigidbody>().velocity = new Vector3(
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f));
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
