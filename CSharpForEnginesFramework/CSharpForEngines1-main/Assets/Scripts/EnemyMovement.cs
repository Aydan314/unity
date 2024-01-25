using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] int m_movespeed = 5;
    [SerializeField] int m_notMovingCooldown = 30;
    [SerializeField] Transform target;
    [SerializeField] ScoreUI scoreSystem;

    private int notMovingCooldown;
    private Vector3 prevPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private bool compare(Vector3 A, Vector3 B, float tolerence)
    {

        return false;
    }

    // Update is called once per frame
    void Update()
    {
        prevPosition = transform.position;

        transform.position = Vector2.MoveTowards(transform.position, target.position, m_movespeed * Time.deltaTime);

        if (prevPosition != transform.position)
        {
            notMovingCooldown = m_notMovingCooldown;
        }
        else
        {
            Debug.Log("fuiehgufiehgruighr");
        }
    }
    private void FixedUpdate()
    {
        if (notMovingCooldown > 0) notMovingCooldown--;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.name == "character")
        {
            scoreSystem.addScore(-10);
        }
    }
}
