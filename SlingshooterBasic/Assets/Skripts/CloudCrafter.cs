using UnityEngine;
using System.Collections;

public class CloudCrafter : MonoBehaviour {

	public int numClouds = 40;
	public Vector3 cloudPosMin;
	public Vector3 cloudPosMax;
	public GameObject[] cloudPrefabs;

	private GameObject[] cloudInstances;




	// Use this for initialization
	void Awake () {

		//make large array
		cloudInstances = new GameObject[numClouds];

		//find cloud parent
		GameObject cloudParent = GameObject.Find ("Clouds");

		//iterate and generate clouds
		for (int i=0; i<numClouds; i++) {

			//randomly chooses prefab

			int chosenPrefab = Random.Range(0, cloudPrefabs.Length);

			//instantiate it

			GameObject cloud = Instantiate( cloudPrefabs[chosenPrefab] );

			//random pos + scale

			Vector3 cPos = Vector3.zero;
			cPos.x = Random.Range(cloudPosMin.x, cloudPosMax.x);
			cPos.y = Random.Range(cloudPosMin.y, cloudPosMax.y);
			cloud.transform.position = cPos;
			//make child to bla

			cloud.transform.parent = cloudParent.transform;

			//add to array

			cloudInstances[i] = cloud;

		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
