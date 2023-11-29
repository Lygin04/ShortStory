using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

public class SayDialog : MonoBehaviour
{
    [SerializeField] private Dialogs _dialog;
    [SerializeField] private TextMeshProUGUI _author;
    [SerializeField] private TextMeshProUGUI _text;
    
    private int index;
    private bool isWrite;
    private void Awake()
    {
        Dialog();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)) Dialog();
    }

    private async void Dialog()
    {
        if(_dialog.Get.Length == index || isWrite) return;

        _author.text = _dialog.Get[index].Name;
        isWrite = await WriteDialog(_dialog.Get[index].Text, _text);  
        index++;
    }

    private async Task<bool> WriteDialog(string text, TextMeshProUGUI meshPro)
    {
        isWrite = true;
        meshPro.text = null;
        foreach (var value in text)
        {
            meshPro.text += value;
            await Task.Delay(50);
        }

        return false;
    }
}
