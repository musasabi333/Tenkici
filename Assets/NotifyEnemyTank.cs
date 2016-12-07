using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifyEnemyTank : MonoBehaviour {

    public int Mask;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("Wall"))
        {
            GetComponentInParent<EnemyTank>().Collission |= Mask;
        }
        Debug.Log(Mask);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag.Equals("Wall"))
        {
            GetComponentInParent<EnemyTank>().Collission &= ~Mask;
        }
        Debug.Log(Mask);
    }
}
