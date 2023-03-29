using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim; //Används för att kontrollera vilken animation som ska utföras

    void Start()
    {
        anim = GetComponent<Animator>(); //Kommer åt gameObjectets animator component
    }

    void Update()
    {
        WalkForward();
        WalkBackward();
        WalkRight();
        WalkLeft();
    }

    void WalkForward()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //Om R-tangenten trycks ned
        {
            anim.SetBool("Forward", true); //Gå över till "spin" animationen
        }
        else //Om R-tangenten inte trycks ned
        {
            anim.SetBool("Forward", false); //Var idle animation
        }
    }

    void WalkBackward()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //Om R-tangenten trycks ned
        {
            anim.SetBool("Backward", true); //Gå över till "spin" animationen
        }
        else //Om R-tangenten inte trycks ned
        {
            anim.SetBool("Backward", false); //Var idle animation
        }
    }

    void WalkRight()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //Om R-tangenten trycks ned
        {
            anim.SetBool("Right", true); //Gå över till "spin" animationen
        }
        else //Om R-tangenten inte trycks ned
        {
            anim.SetBool("Right", false); //Var idle animation
        }
    }

    void WalkLeft()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //Om R-tangenten trycks ned
        {
            anim.SetBool("Left", true); //Gå över till "spin" animationen
        }
        else //Om R-tangenten inte trycks ned
        {
            anim.SetBool("Left", false); //Var idle animation
        }
    }
}
