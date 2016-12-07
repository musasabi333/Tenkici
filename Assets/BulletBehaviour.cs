using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public int energyDestroy = 1;
    public int speed = 1;
    public Vector2 tankOrientation;
	
	void Update () {
        transform.Translate(tankOrientation * speed);
	}
    
}
