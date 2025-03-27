using UnityEngine;

public class AngularVelocity : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 velocity = new Vector3(5, 0, 0);
    [SerializeField] private Vector3 spin = new Vector3(0, 5, 0);
    [SerializeField] private float magnusEffectStrength = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = Mathf.Infinity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.linearVelocity = velocity;
            rb.angularVelocity = spin;
        }
    }

    void FixedUpdate() 
    {
        {
            ApplyMagnusEffect();
        }
    }

    void ApplyMagnusEffect()
    {
        if (rb.linearVelocity.magnitude > 0 && rb.angularVelocity.magnitude > 0)
        {
            Vector3 magnusForce = magnusEffectStrength * Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
            rb.AddForce(magnusForce, ForceMode.Force);
        }
    }
}
