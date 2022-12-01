using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_menu : MonoBehaviour
{
    VisualElement root;

    private void Start() {
        root = GetComponent<UIDocument>().rootVisualElement;

        root.Q<Button>("clickme").RegisterCallback<ClickEvent>(onButtonClick);
    }

    void onButtonClick(ClickEvent evt){
        Debug.Log("Button clicked");
    }
}
