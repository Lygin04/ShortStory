using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Dialog/" + nameof(Dialogs))]
public class Dialogs : ScriptableObject
{
    [Serializable]
    public class Dialog
    {
        [SerializeField] private string _author;
        [SerializeField] private Sprite _avatar;
        [SerializeField] [TextArea(1, 5)] private string _text;

        public string Name => _author;
        public Sprite Avatar => _avatar;
        public string Text => _text;
    }

    [SerializeField] private Dialog[] _dialogs;

    public Dialog[] Get => _dialogs;
}
