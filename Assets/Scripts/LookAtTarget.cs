using UnityEngine;
using System.Collections;
using Unity.Android.Types;

public class LookAtTarget : MonoBehaviour {

	static public GameObject target; // the target that the camera should look at
	public AudioSource[] sons;
	public AudioSource musicaSol;
	void Start () {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");

			ApenasMusicaSol();
			musicaSol = GetComponent<AudioSource>();
			musicaSol.Play(0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (target)
			transform.LookAt(target.transform);
	}

	void ApenasMusicaSol() {
		sons = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach (AudioSource s in sons) {
			if(s != musicaSol)
				s.Stop();
		}
	}	
}
