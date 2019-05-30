﻿using UnityEngine;

public class PursuitBehaviour : MonoBehaviour {

    public GameObject Goal;
    public float Speed;

    void Update ()

    {

        Vector3 Velocity = (Goal.GetComponent<WanderBehaviour>().Speed * Goal.transform.forward);        
        Vector3 Direction = Goal.transform.position - transform.position;
        transform.forward = Velocity.normalized + Direction.normalized;
        transform.position += transform.forward * (Time.deltaTime * Speed * Vector3.Distance(transform.position, Goal.transform.position));

    }
}
