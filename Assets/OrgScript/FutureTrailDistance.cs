using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class FutureTrailDistance : MonoBehaviour
{
    public Animator trail_animator;
    public float MaxDis = 1.0f; // �X���C�_�[�̒l�̍ő�l�ƂȂ�

    public void TrailChange(SliderEventData eventdata)
    {
        trail_animator.SetFloat("D_trail", eventdata.NewValue * MaxDis); // �O�Ղ���铧���̃A�o�^�[���ǂꂾ����s���邩�����肷��
        
    }
}
