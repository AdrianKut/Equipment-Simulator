using UnityEngine;

public enum ItemType
{
    Sword,
    Shield
}

public abstract class ScriptableItem : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite Icon;
    public ItemType ItemType;

    public virtual string GetDescription()
    {
        return Description +"\n";
    }
}
