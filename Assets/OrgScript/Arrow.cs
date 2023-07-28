using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform[] cylinder = new Transform[10];
    public Transform[] indextip = new Transform[2];
    int i;
    float f;
    // �O���̊�ƂȂ郍�[�J����ԃx�N�g��
    [SerializeField] Vector3 _forward = Vector3.forward; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �^�[�Q�b�g�ւ̌����x�N�g���v�Z
        var dir = indextip[1].position - indextip[0].position;

        // �^�[�Q�b�g�̕����ւ̉�]
        var lookAtRotation = Quaternion.LookRotation(dir, Vector3.up);

        // ��]�␳
        var offsetRotation = Quaternion.FromToRotation(_forward, Vector3.forward);

        for (i = 0; i < 10; i++)
        {
            f = 1f - i * 0.1f;
            cylinder[i].position = Vector3.Lerp(indextip[0].position, indextip[1].position, f);
            cylinder[i].rotation = lookAtRotation * offsetRotation;
        }
    }
}
