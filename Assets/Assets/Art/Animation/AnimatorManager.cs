using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator animator;
    int horisontal;
    int vertical;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        horisontal = Animator.StringToHash("Horisontal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void UpdateAnimatorValues(float HM, float VM)
    {
        float snappedHorisontal;
        float SnappedVertical;

        #region Snapped Horisontal
        if (HM > 0 && HM <= 0.55f)
        {
            snappedHorisontal = 0.5f;
        }
        else if (HM > 0.55f)
        {
            snappedHorisontal = 1;
        }
        else if (HM < 0 && HM >= -0.55f)
        {
            snappedHorisontal = -0.5f;
        }
        else if (HM < -0.55f)
        {
            snappedHorisontal = -1;
        }
        else
        {
            snappedHorisontal = 0;
        }
        #endregion
        #region Snapped Vertical
        if (VM > 0 && VM <= 0.55f)
        {
            SnappedVertical = 0.5f;
        }
        else if (VM > 0.55f)
        {
            SnappedVertical = 1;
        }
        else if (VM < 0 && VM >= -0.55f)
        {
            SnappedVertical = -0.5f;
        }
        else if (VM < -0.55f)
        {
            SnappedVertical = -1;
        }
        else
        {
            SnappedVertical = 0;
        }
        #endregion


        animator.SetFloat(horisontal, snappedHorisontal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical , SnappedVertical , 0.1f, Time.deltaTime);
    }
}
