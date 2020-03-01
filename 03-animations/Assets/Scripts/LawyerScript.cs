using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawyerScript : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        _anim.SetFloat("Move", direction);
    }
}
