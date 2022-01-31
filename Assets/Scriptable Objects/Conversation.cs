using UnityEngine;
using UnityEngine.UI;

public enum Mood {
    Neutral,
    Angry
}

[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(2, 5)]
    public string text;
    public Mood mood;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public Character speakerLeft;
    public Character speakerRight;
    public Line[] lines;
    public Question question;
    public Conversation nextConversation;
}
