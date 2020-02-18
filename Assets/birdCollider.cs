using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdCollider : MonoBehaviour
{
    public GameObject self;
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(self);
        }
    }
}
