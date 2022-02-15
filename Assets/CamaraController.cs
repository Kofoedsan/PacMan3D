using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    [SerializeField] private Transform packman;

    private void Update()
    {
        transform.position = new Vector3(packman.position.x, packman.position.y +3, packman.position.z -5);
    }
}
