using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour {

	float Speed = 10;
	public Text commandText;

	// Use this for initialization
	void Start () {
		
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
			commandText.text = "if(fruit == Strawberry){\n\tYou win\n}else if(fruit == Banana){\n\tYou win}else{\nYou lose\n}";
		} else {
			Debug.Log ("Try Again");
		}
	}
}
