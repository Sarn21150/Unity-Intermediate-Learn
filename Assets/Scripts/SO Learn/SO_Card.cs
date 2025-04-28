using UnityEngine;

[CreateAssetMenu (menuName =  "Profile/Card")]

public class SO_Card : ScriptableObject
{
    [Header("Character Infos")]
    public string Name;
    public string Description;
    public Type ElementalType;
    
    [Space]
    public int Cost;
    public int Health;
    public int ATK;
    public Sprite CharacterImage;
}

public enum Type
{
    Fire,
    Ice,
    Wind,
    Lightning,
    Earth,
    Water

}
