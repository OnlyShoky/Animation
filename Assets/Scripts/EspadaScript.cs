using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaScript : MonoBehaviour
{
    public GameObject owner;

    void Start()
    {
        Physics2D.IgnoreCollision(owner.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
    }
}
