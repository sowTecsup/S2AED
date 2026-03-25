
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public static SkillManager Instance;


    [SerializeField] private List<Skill> skillList;

    public void NameOfSkill<T>(T skill) where T : Skill
    {
        Debug.Log(skill.SkillName);
    }



    public bool TryLearnSkill<T>(Player sender , T target , out T Result) where T : Skill
    {
        if (sender.Level >= target.LevelRestriction)
        {
            Result = target;
            return true;
        }
        else
        {
            Result = default;
            return false;
        }
    }



    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

}
