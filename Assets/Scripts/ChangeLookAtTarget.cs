using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at

    public AudioSource[] sons; 
	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget script to be this gameobject.
		LookAtTarget.target = target;
		Camera.main.fieldOfView = 60*target.transform.localScale.x / 2;

	IsolarSons();
		target.GetComponent<AudioSource>().Play();
	}

	void IsolarSons() {
		sons = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach (AudioSource s in sons) {
			s.Stop();
		}
	}
}
