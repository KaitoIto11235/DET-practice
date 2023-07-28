using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class FutureAvatarDistance : MonoBehaviour
{
    public Animator[] avatar_animator = new Animator[5];
    public float MaxDis = 1.0f;

    public void DistanceChange(SliderEventData eventData)
    {
        // アバターの先行距離を変更
        avatar_animator[0].SetFloat("D_100", eventData.NewValue * MaxDis);
        avatar_animator[1].SetFloat("D_80", eventData.NewValue * 0.8f * MaxDis);
        avatar_animator[2].SetFloat("D_60", eventData.NewValue * 0.6f * MaxDis);
        avatar_animator[3].SetFloat("D_40", eventData.NewValue * 0.4f * MaxDis);
        avatar_animator[4].SetFloat("D_20", eventData.NewValue * 0.2f * MaxDis);

    }
}
