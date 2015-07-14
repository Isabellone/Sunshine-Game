using UnityEngine;
using System.Collections;

public class Slingshot : MonoBehaviour {

	public GameObject prefabProjectile;
	public float shotMult = 10f;

	private GameObject launchPoint;
	private Vector3 launchPos;
	private GameObject projectile;

	bool aimingMode;


	void Awake() {

		Transform launchPointTransform = transform.Find("LaunchPoint");
		launchPoint = launchPointTransform.gameObject;
		launchPoint.SetActive (false);

		launchPos = launchPointTransform.position;

	}

	void OnMouseEnter() {

		//print ("Yay the mouse has entered");
		launchPoint.SetActive (true);
	}

	void OnMouseExit(){

		//print ("Oh no the mouse has exited");
		launchPoint.SetActive (false);
	}


	void OnMouseDown() {

		aimingMode = true;

		projectile = Instantiate (prefabProjectile) as GameObject;

		projectile.transform.position = launchPos;

		projectile.GetComponent<Rigidbody> ().isKinematic = true;

	}

	void Update () {

		if(!aimingMode) {
			return;
		}
		Vector3 mousePos2D = Input.mousePosition;

		mousePos2D.z = - Camera.main.transform.position.z;
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);

		Vector3 mouseDelta = mousePos3D - launchPos;

		float maxMagnitude = this.GetComponent<SphereCollider>().radius;

		mouseDelta = Vector3.ClampMagnitude(mouseDelta, maxMagnitude);

		projectile.transform.position = launchPos + mouseDelta;

		if(Input.GetMouseButtonUp(0)){

			FollowCam.S.poi = projectile;
			aimingMode = false;
			projectile.GetComponent<Rigidbody> ().isKinematic = false;
			projectile.GetComponent<Rigidbody>().velocity = -mouseDelta * shotMult;
		}

	}


}
