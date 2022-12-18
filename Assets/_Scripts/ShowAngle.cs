using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowAngle : MonoBehaviour
{
    [SerializeField] Transform origin;
    [SerializeField] Transform first;
    [SerializeField] Transform second;
    [SerializeField] TMP_Text text;


    private void Update() {

        Vector2 dir1 = first.position - origin.position;
        Vector2 dir2 = second.position - origin.position;

        float angle = Vector2.Angle( - transform.right, dir2);

        // print(angle);
        // print("Transform : "+transform.right);
        // print("Vector"+Vector2.right);
        text.text = angle.ToString();
    }
    
}
