using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceTest : MonoBehaviour
{
    private KeywordRecognizer _keywordRecognizer;

    private void Start()
    {
        var keywords = new string[]
        {
            "Left",
            "World",
            "Programming",
            "Gamers"
        };
        _keywordRecognizer = new KeywordRecognizer(keywords);
        _keywordRecognizer.OnPhraseRecognized += RespondToVoice;
        _keywordRecognizer.Start();
    }

    private void RespondToVoice(PhraseRecognizedEventArgs args)
    {
        print($"Phrase Detected was [{args.text}] with confidence level of [{args.confidence}] at the length of [{args.phraseDuration}]");
    }
} 