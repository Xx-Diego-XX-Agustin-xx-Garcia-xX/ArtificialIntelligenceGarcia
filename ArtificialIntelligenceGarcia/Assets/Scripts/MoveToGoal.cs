using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public float speed = 2.0f;
    public float accuracy = 0.01f;
    public Transform goal;
    void Start()
    {
        this.transform.LookAt(goal.position);
    }
    void LateUpdate()
    {
        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.magenta);
        if(direction.magnitude > accuracy)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}