using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class Hejbani : MonoBehaviour
{
    const float multiplier = 1f;
    const float ACCEL = 0.3f * multiplier;
    const float MAX_SPEED = 3f * multiplier;
    const float JUMP = 5f;
    const float FRICTION = 0.95f;


    Rigidbody dick;

    [SerializeField]
    KeyCode keyJump;

    [SerializeField]
    KeyCode keyRestart;

    [SerializeField]
    KeyCode keyLeft, keyRight, keyUp, keyDown;

    void Start()
    {
        dick = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = dick.velocity;

        if (Input.GetKey(keyJump) && dick.velocity.y < 0.1f)
        {
            Debug.Log("aaaaa");
            vel.y += JUMP;
        }
        else if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return;
        }

        if (Input.GetKey(keyLeft))
            vel.x += ((vel.x - ACCEL) < -MAX_SPEED ? 0 : -ACCEL);
        if (Input.GetKey(keyRight))
            vel.x += ((vel.x + ACCEL) > MAX_SPEED ? 0 : ACCEL);
        if (Input.GetKey(keyUp))
            vel.z += ((vel.z + ACCEL) > MAX_SPEED ? 0 : ACCEL);
        if (Input.GetKey(keyDown))
            vel.z += ((vel.z - ACCEL) < -MAX_SPEED ? 0 : -ACCEL);

        vel.y *= (vel.y > 0) ? FRICTION : 1;

        dick.velocity = new Vector3(vel.x * FRICTION, vel.y, vel.z * FRICTION);
    }

    // private static float GetIncSpeed(float actualSpeed){
    //     float newSpeed = actualSpeed;
    //     if (actualSpeed > 0) 
    //         newSpeed += SPEED;
    //     else if (actualSpeed < 0)
    //         newSpeed -= SPEED;            
    // }

}
