using System.Runtime.CompilerServices;
using UnityEngine;

public class BackFlip : MonoBehaviour
{
    [SerializeField] float jumpForce = 7f;
    [SerializeField] float torqueForce = 400f;

    private Rigidbody rb;
    private bool hadFlipped = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        Invoke(nameof(DoBackFlip), 0.1f);
    }

    void DoBackFlip()
    {
        rb.AddTorque(Vector3.right * jumpForce, ForceMode.Impulse);
        hadFlipped = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
