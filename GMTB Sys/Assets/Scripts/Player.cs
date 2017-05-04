using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // Syntax and Object types learnt from
    // https://unity3d.com/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game

    [HideInInspector]
    public bool facingRight = true;

    public float moveForce = 365f;
    public float maxSpeed = 5f;

    private Animator anim;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake ()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}

    private void FixedUpdate()
    {
        // Gets is the current movement, h is positive or negative
        float h = Input.GetAxis("Horizontal");

        // Using MathF.Absolute gets us a positive number for the speed regardless of the direction.
        // This ensures the animation loop continues normally
        // This also triggers the animation to change state, if the speed is higher than 0.1, the animator switches to the walking animation
        anim.SetFloat("Speed", Mathf.Abs(h));

        // Applies the current movement direction if it is below the max speed
        // Will make the player gradually speed up until it hits the max speed
        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        // If the players velocity is higher than their max speeed, clamp their speed to their max speed
        // MathF.Sign will return a 1 or -1 depending on the current velocity, needed to set the max speed to the correct direction
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        // Call the sprite flip method if h changes (I.E Player changes direction)
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        // Inverts the facingRight variable
        // Inverts the texture scale.
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    // Code to call gameover screen
    // GameController.instance.PlayerDied();
}
