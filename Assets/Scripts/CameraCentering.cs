using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCentering : MonoBehaviour
{
    const float OFFSET = 3f;

    [SerializeField]
    Rigidbody player;
    
    Rigidbody cam;
    // Start is called before the first frame update
    void Start()
    {
        this.cam = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.cam.position = new Vector3(
            player.position.x, 
            player.position.y + OFFSET, 
            player.position.z - OFFSET
            );
    }
}
