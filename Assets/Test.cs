using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    private bool headsetConnected;
	
    [SerializeField] private string BaseMessage = "Headset connected: ";
    [SerializeField] private Text MessageText;
    [SerializeField] private Button DetectButton;

    private void Start () {
        headsetConnected = DetectHeadset.Detect();
        DetectButton.onClick.AddListener(() => headsetConnected = DetectHeadset.Detect());
    }

    private void Update()
    {
        MessageText.text = BaseMessage + headsetConnected;
    }
}