using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Apply forward force to instantiated prefab
/// </summary>
public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectilePrefab = null;
    public Transform startPoint = null;
    public float launchSpeed = 1.0f;
    public GameObject muzzleFlashPrefab;
    private float destroyTimer = 0.1f;

    Animator m_animator;

    private void Start()
    {
        m_animator = GetComponent<Animator>();
    }


    public void Fire()
    {
        GameObject tempFlash;
        tempFlash = Instantiate(muzzleFlashPrefab, startPoint.position, startPoint.rotation);
        Destroy(tempFlash, destroyTimer);

        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
        if (newObject.TryGetComponent(out Rigidbody rigidBody))
        {
            ApplyForce(rigidBody);
        }
    }

    private void ApplyForce(Rigidbody rigidBody)
    {
        Vector3 force = startPoint.forward * launchSpeed;
        rigidBody.AddForce(force);
    }

}
