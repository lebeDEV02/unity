using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float RandomNumber = 7;
	public GameObject SomeObject;

    // Start is called before the first frame update
    void Start()
    {
      Randomizer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	 void Randomizer() {
		Debug.Log(RandomNumber);
	 }
}
