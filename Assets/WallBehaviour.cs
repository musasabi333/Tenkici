using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour {

    public int energy;
    public Sprite brokenSprite;
	// Use this for initialization
	void Start () {
        energy = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            energy--;
            if (energy == 0)
                Destroy(this.gameObject);
            else if (energy == 1)
                this.GetComponent<SpriteRenderer>().sprite = brokenSprite;
           
        }
    }
}
