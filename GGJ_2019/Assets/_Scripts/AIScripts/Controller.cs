﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AvatarFunctionality))]
public class Controller : MonoBehaviour {
    protected AvatarFunctionality m_avatar;
	// Use this for initialization
	void Start () {
        m_avatar = GetComponent<AvatarFunctionality>();
	}
}
