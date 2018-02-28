using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour {

    public GameObject fs;
    public void TurnRight()
    {
        fs.GetComponent<Move>().Rmas();
    }
}
