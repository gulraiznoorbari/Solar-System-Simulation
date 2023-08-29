using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Tooltip("The distance this projectile will move each second in meters.")]
    [SerializeField] private float projectileSpeed = 3.0f;
    [Tooltip("How far away from the main camera before destroying the projectile gameobject in meters.")]
    [SerializeField] private float destroyDistance = 20.0f;

    private void Update()
    {
        MoveProjectile();
    }

    /// Move the projectile in the direction it is heading
    private void MoveProjectile()
    {
        // move the transform
        transform.position = transform.position + transform.forward * projectileSpeed * Time.deltaTime;
        // calculate the distance from the main camera
        float dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        // if the distance is greater than the destroyDistance
        if (dist > destroyDistance)
        {
            Destroy(this.gameObject); // destroy the gameObject
        }
    }
}