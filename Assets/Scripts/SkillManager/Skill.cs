using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "LeagueOfLegends/Skill")]
public class Skill : ScriptableObject
{
    private string skillName;
    private string skillDescription;

    private int cost;
    private float cooldown;
    private float damage;

    private int levelRestriction;

    public string SkillName => skillName;
    public string SkillDescription => skillDescription;
    public int Cost => cost;
    public float Cooldown => cooldown;
    public float Damage => damage;

    public int LevelRestriction => levelRestriction;
}
