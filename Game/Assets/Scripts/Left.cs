using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour {

	// Use this for initialization
    public GameObject fs;
	public void TurnLeft()
    {
        fs.GetComponent<Move>().Rmenos();
    }
}
