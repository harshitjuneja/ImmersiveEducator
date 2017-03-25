using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour {

	float Speed = 10;
	public Text commandText;
	static int c = 0;
	public AudioSource audioGood, audioBad;

	// Use this for initialization
	void Start () {
		c = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 5 * Time.deltaTime * Speed, 0);	
	}

	public void stopRotation(){
		Speed = 0;
	}

	public void resumeRotation(){
		Speed = 10;
	}

	public void selected(){
		if (gameObject.name == "Apple") {
			audioGood.Play ();
			Destroy (gameObject);
			commandText.text = "Congrats. \nAn apple a day keeps doctor away.\n" +
			"if (fruit == Banana) { Go Back };";
			c = 1;
		} else if (gameObject.name == "Banana" && c == 1) {
			SceneManager.LoadScene (0, LoadSceneMode.Single);
		} else {
			audioBad.Play ();
		}
	}
}
