using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class FutureTrailDistance : MonoBehaviour
{
    public Animator trail_animator;
    public float MaxDis = 1.0f; // スライダーの値の最大値となる

    public void TrailChange(SliderEventData eventdata)
    {
        trail_animator.SetFloat("D_trail", eventdata.NewValue * MaxDis); // 軌跡を作る透明のアバターがどれだけ先行するかを決定する
        
    }
}
