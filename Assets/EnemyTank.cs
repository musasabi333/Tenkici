using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : Tank {

    public int Collission = 0;
    public int Shooter = 0;
    
    // Use this for initialization
	void Start () {
        float probs = Random.value;
        if (probs <= 0.4)
        {
            Speed = 0.5f;
            Shooter = 1;
        }
        else if (probs <= 0.7)
        {
            Speed = 0.3f;
            Shooter = 3;
        }
        else
        {
            Speed = 0.1f;
            Shooter = 5;
        }
	}
	
	// Update is called once per frame
	void Update () {
		//if (Time.time % Speed == 0)
        //{
            if (Random.value * 10 <= Shooter)
            {
                Shoot();
            }
            else
            {
                Move();
            }
        //}
	}

    void Shoot()
    {
        
    }

    void Move()
    {
        int upValue = (Collission & 1) == 0 ? 2000 : 0;
        int downValue = (Collission & 2) == 0 ? 10000 : 0;
        int leftValue = (Collission & 4) == 0 ? 5000 : 0;
        int rightValue = (Collission & 8) == 0 ? 5000 : 0;

        if (downValue > 0)
        {
            MoveDown();
        }
        else if (leftValue > 0 || rightValue > 0)
        {
            if (leftValue == 0)
            {
                MoveRight();
            }
            else if (rightValue == 0)
            {
                MoveLeft();
            }
            else if (Random.value > 0.5)
            {
                MoveRight();
            }
            else
            {
                MoveLeft();
            }
        }
        else
        {
            MoveUp();
        }
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {

    }

    void MoveUp()
    {
        transform.Translate(Vector2.up * Speed);
    }

    void MoveDown()
    {
        transform.Translate(Vector2.down * Speed);
    }

    void MoveLeft()
    {
        transform.Translate(Vector2.left * Speed);
    }

    void MoveRight()
    {
        transform.Translate(Vector2.right * Speed);
    }
}
