using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AvatarFunctionality : MonoBehaviour {
    [SerializeField]
    protected float m_moveSpeed;
    [SerializeField]
    protected float m_angularSpeed;
    protected Rigidbody m_rb;
    protected Vector3 m_strafeVelocity;
    protected Vector3 m_linearVelocity;
    protected Vector3 m_angularVelocity;
    protected Vector3 m_verticalVelocity;
	// Use this for initialization
	protected void Start () {
        m_rb = GetComponent<Rigidbody>();
	}

    protected void FixedUpdate()
    {
        Vector3 upVelocity = Vector3.up * m_rb.velocity.y;
        m_rb.velocity = /*m_verticalVelocity*/upVelocity + m_linearVelocity + m_strafeVelocity;
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

    public void SetVerticalRatio(float ratio = 0)
    {
        if (ratio != 0)
            m_verticalVelocity = Vector3.down * ratio * m_moveSpeed;
        else
            m_verticalVelocity = transform.up * m_rb.velocity.y;
    }

    public void SetAngularRatio(float ratio)
    {
        m_angularVelocity = transform.up * m_angularSpeed * ratio;
    }
}