using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class FutureTrailDistance : MonoBehaviour
{
    [SerializeField] Animator trail_animator;
    [SerializeField] float MaxDis = 1.0f; // スライダーの値の最大値となる
    public TrailRenderer handR;
    public TrailRenderer thumbR; 
    public TrailRenderer indexR;
    public TrailRenderer middleR;
    public TrailRenderer ringR;
    public TrailRenderer pinkyR;
    public float timeOnDis;

    public void TrailChange(SliderEventData eventdata)
    {
        // 軌跡を作る透明のアバターがどれだけ先行するかを決定する
        trail_animator.SetFloat("D_trail", eventdata.NewValue * MaxDis);

        // 距離の変化による軌跡の長さの変更
        // 現アニメーションは2秒で一周するため、2をかける
        timeOnDis = eventdata.NewValue * MaxDis * 2f / trail_animator.GetFloat("S_keisuu");

        // BhandR.timeは身体部位B-hand_Rの軌跡の持続時間
        handR.time = timeOnDis;
        thumbR.time = timeOnDis;
        indexR.time = timeOnDis;
        middleR.time = timeOnDis;
        ringR.time = timeOnDis;
        pinkyR.time = timeOnDis;
        
    }
}
