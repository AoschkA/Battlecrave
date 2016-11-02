using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveVertical = Input.GetAxis("Vertical");
        
        if (moveVertical != 0) {
            animator.SetBool("isMoving", true);
        } else {
            animator.SetBool("isMoving", false);
        }
	}
}
