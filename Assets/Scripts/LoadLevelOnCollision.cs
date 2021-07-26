using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    private void OnCollisionEnter(Collision other) {
        if (other.collider.tag == strTag)
            Debug.Log("collision");
    }
}
