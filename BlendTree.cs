using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree : MonoBehaviour
{
    public float smoothBlend = 0.1f;
    private Animator anim;

	void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
        
    void Move(float x, float y)
    {
        anim.SetFloat("Blend", y, smoothBlend, Time.deltaTime);   	
    }
}
