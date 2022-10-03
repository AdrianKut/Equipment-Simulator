using UnityEngine;

[CreateAssetMenu(fileName = "New Sword",menuName = "Item/Sword")]
public class ScriptableSword : ScriptableItem
{
    public int Attack;
    public float AttackSpeed;

    public override string GetDescription()
    {
        return base.GetDescription() + $"Attack: {Attack}\nAttackSpeed: {AttackSpeed}";
    }
}
