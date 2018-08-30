using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_Bahavior : MonoBehaviour {

    // Use this for initialization
    public MeshRenderer m_MR;
    public Collider m_CL;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("My Mesh Renderer status: " + m_MR.enabled);
        Debug.Log("My Collider status: " + m_CL.enabled);
	}
}
