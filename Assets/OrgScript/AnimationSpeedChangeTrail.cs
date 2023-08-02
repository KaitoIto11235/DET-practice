using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class AnimationSpeedChangeTrail : MonoBehaviour
{
    public Animator trail_animator;
    [SerializeField] FutureTrailDistance script;
    float timeOnSpeed;
    
    public void SpeedChangeTrail(SliderEventData eventData)
    {
        trail_animator.SetFloat("S_keisuu", eventData.NewValue);

        // アニメーション速度による軌跡の持続時間の変更
        timeOnSpeed = script.timeOnDis / trail_animator.GetFloat("S_keisuu");

        script.handR.time = timeOnSpeed;
        script.thumbR.time = timeOnSpeed;
        script.indexR.time = timeOnSpeed;
        script.middleR.time = timeOnSpeed;
        script.ringR.time = timeOnSpeed;
        script.pinkyR.time = timeOnSpeed;
    }
}
