using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AvatarFunctionality : MonoBehaviour {
    [SerializeField]
    protected float m_moveSpeed;
    protected float m_angularSpeed;
    protected Rigidbody m_rb;
    protected Vector3 m_strafeVelocity;
    protected Vector3 m_linearVelocity;
    protected Vector3 m_angularVelocity;
	// Use this for initialization
	protected void Start () {
        m_rb = GetComponent<Rigidbody>();
	}

    protected void FixedUpdate()
    {
        Vector3 upVelocity = Vector3.up * m_rb.velocity.y;
        m_rb.velocity = upVelocity + m_linearVelocity + m_strafeVelocity;
        m_rb.angularVelocity = m_angularVelocity;
    }

    public void SetLinearRatio(float ratio)
    {
        m_linearVelocity = transform.forward * ratio * m_moveSpeed;
    }

    public void SetStrafeRatio(float ratio)
    {
        m_strafeVelocity = transform.right * ratio * m_moveSpeed;
    }

    public void SetAngularRatio(float ratio)
    {
        m_angularVelocity = transform.up * m_angularSpeed * ratio;
    }
}