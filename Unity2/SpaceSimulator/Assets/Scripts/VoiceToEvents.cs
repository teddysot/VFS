using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Windows.Speech;

public class VoiceToEvents : MonoBehaviour
{

    [SerializeField]
    private KeywordEvent[] _Actions;

    private Dictionary<string, UnityEvent> _KeywordEvents;

    private KeywordRecognizer _KWR;

	private void OnEnable()
    {
        PopulateDictionary();
        _KWR = new KeywordRecognizer(_KeywordEvents.Keys.ToArray());
        _KWR.OnPhraseRecognized += OnKWRecognized;
        _KWR.Start();
    }

    private void OnDisable()
    {
        _KWR.Stop();
        _KWR.OnPhraseRecognized -= OnKWRecognized;
    }

    private void PopulateDictionary()
    {
        _KeywordEvents = new Dictionary<string, UnityEvent>(_Actions.Length);
        foreach (var item in _Actions)
        {
            _KeywordEvents[item.Keyword] = item.ActionToDo;
        }
    }

    private void OnKWRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.LogFormat("Recognized: {0} - {1} @ {2}", args.text, args.confidence, DateTime.Now);
        _KeywordEvents[args.text].Invoke();
    }

}
