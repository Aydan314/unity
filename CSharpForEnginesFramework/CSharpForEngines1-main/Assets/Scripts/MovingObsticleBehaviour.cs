using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObsticleBehaviour : MonoBehaviour
{
    [SerializeField] Transform m_startPoint;
    [SerializeField] Transform m_endPoint;
    [SerializeField] int m_movespeed = 5;

    Transform target;
    bool targetState = false;

    // Start is called before the first frame update
    void Start()
    {
        target = m_startPoint;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, m_movespeed * Time.deltaTime);

    }

    void ChangeTarget()
    {
        targetState = !targetState;

        if (targetState) target = m_endPoint;
        else target = m_startPoint;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MovingObsticleWaypoint"))
        {
            ChangeTarget();
        }
    }
}
