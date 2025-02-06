using UnityEngine;

public class AnimationState : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        // Initialize all animation parameters
        animator.SetBool("Walking", false);
        animator.SetBool("Idle", true); // Start in Idle state
        animator.SetBool("sprint", false);
        animator.SetBool("backwalk", false);
    }

    void Update()
    {
        // Detect input states
        bool forwardPressed = Input.GetKey("w");
        bool sprintPressed = Input.GetKey(KeyCode.LeftShift);
        bool walkbackPressed = Input.GetKey("s");

        // Handle Backward Walking animation
        if (walkbackPressed)
        {
            animator.SetBool("Idle", false);
            animator.SetBool("backwalk", true);
            animator.SetBool("Walking", false);
            animator.SetBool("sprint", false);
        }
        else if (!walkbackPressed && !forwardPressed && !sprintPressed)
        {
            animator.SetBool("backwalk", false);
            animator.SetBool("Idle", true);
        }
sssssssssss
        // Handle Walking animation
        if (forwardPressed && !sprintPressed)
        {
            animator.SetBool("Walking", true);
            animator.SetBool("Idle", false);
            animator.SetBool("backwalk", false);
            animator.SetBool("sprint", false);
        }
        else if (!forwardPressed && !walkbackPressed)
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Idle", true);
        }

        // Handle Sprint animation
        if (forwardPressed && sprintPressed)
        {
            animator.SetBool("Walking", false);
            animator.SetBool("sprint", true);
            animator.SetBool("Idle", false);
            animator.SetBool("backwalk", false);
        }
        else if (!sprintPressed && animator.GetBool("sprint"))
        {
            animator.SetBool("sprint", false);
            animator.SetBool("Walking", true);
        }
    }
}
