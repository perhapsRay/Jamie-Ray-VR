using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health = 5;

    Rigidbody m_Rigidbody;
    float m_Speed;

    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 1;
            Score.scoreCounter = Score.scoreCounter + 5;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.tag == "Tree")
        {
            Health.healthCounter = Health.healthCounter - 1;
        }
    }
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = -transform.forward * m_Speed;
    }
}
