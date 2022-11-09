using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauseExplosion : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> ExplosionTargets;
    private SphereCollider sphereCollider;

    public float explosionRadius = 2.0f;
    public float explosionStrength = 1000.0f;
    public float explosionLift = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && ExplosionTargets.Count != 0)
        {
            foreach (Rigidbody r in ExplosionTargets)
            {
                r.AddExplosionForce(explosionStrength, gameObject.transform.position, explosionRadius, explosionLift);
            }
        }
    }

    void FixedUpdate()
    {
        if (explosionRadius != sphereCollider.radius)
        {
            sphereCollider.radius = explosionRadius;
        }
    }

    void OnTriggerEnter(Collider otherObj)
    {
        ExplosionTargets.Add(otherObj.gameObject.GetComponent<Rigidbody>());
    }

    void OnTriggerExit(Collider otherObj)
    {
        ExplosionTargets.Remove(otherObj.gameObject.GetComponent<Rigidbody>());
    }

}
