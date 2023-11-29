using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SayDialog : MonoBehaviour
{
    [SerializeField] private Dialogs _dialog;
    [SerializeField] private TextMeshProUGUI _author;
    [SerializeField] private TextMeshProUGUI _text;
    
    private int index;

    private void Awake()
    {
        Dialog();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)) Dialog();
    }

    public void Dialog()
    {
        if(_dialog.Get.Length == index) return;

        _author.text = _dialog.Get[index].Name;
        _text.text = _dialog.Get[index].Text;
        index++;
    }
}
