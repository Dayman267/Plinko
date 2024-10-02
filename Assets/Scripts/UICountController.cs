using System;
using TMPro;
using UnityEngine;

public class UICountController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMP;
    private uint count;

    private void Awake()
    {
        ResetCount();
    }

    private void AddCount()
    {
        count++;
        SetText();
    }

    public void ResetCount()
    {
        count = 0;
        SetText();
    }

    private void SetText() => textMP.text = count.ToString();

    private void OnEnable()
    {
        Ball.OnTouch += AddCount;
    }

    private void OnDisable()
    {
        Ball.OnTouch -= AddCount;
    }
}
