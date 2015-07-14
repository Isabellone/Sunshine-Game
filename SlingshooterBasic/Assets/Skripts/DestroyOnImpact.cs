using UnityEngine;
using System.Collections;


public class DestroyOnImpact : MonoBehaviour {

	void OnCollisionEnter (Collision col)

	{
		if(col.gameObject.name == "target")
		{
			Destroy(col.gameObject);

		}

	}

}
