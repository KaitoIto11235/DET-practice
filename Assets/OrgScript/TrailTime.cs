using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class TrailTime : MonoBehaviour
{
    public TrailRenderer TR;
    
    public void TrailTimeChange(SliderEventData eventData)
    {
        TR.time = 0.2f / eventData.NewValue;
    }
}
