using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private ClickHandler _clickHandler;

    private int _counter;
    private Coroutine _coroutine;
    private WaitForSeconds _waitForSeconds;

    public event UnityAction<int> Counted;

    private void OnEnable()
    {
        _clickHandler.ButtonPressed += OnButtonPressed;
    }

    private void OnDisable()
    {
        _clickHandler.ButtonPressed -= OnButtonPressed;
    }

    private void OnButtonPressed(bool isPressed)
    {
        if (isPressed == true)
        {
             _coroutine = StartCoroutine(DelaySpawnOre());
        }
        else
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
        }
    }

    private IEnumerator DelaySpawnOre()
    {
        while (true)
        {
            _counter++;
            Counted?.Invoke(_counter);
            yield return _waitForSeconds;
        }
    }
}
