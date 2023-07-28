using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class AnimationSpeedChange : MonoBehaviour
{
    public Animator _animator;
    
    public void SpeedChange(SliderEventData eventData)
    {
        _animator.SetFloat("S_keisuu", eventData.NewValue);
    }
}
