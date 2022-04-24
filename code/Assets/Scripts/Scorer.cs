using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    float numHits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            numHits++;
            Debug.Log("You've bumped into a thing this many times:  " + numHits);
        }
    }
}
