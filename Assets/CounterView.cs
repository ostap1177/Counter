using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.Counted += OnCounted;
    }

    private void OnDisable()
    {
        _counter.Counted -= OnCounted;
    }

    private void OnCounted(int counter)
    { 
        _text.text = counter.ToString();
    }
}
