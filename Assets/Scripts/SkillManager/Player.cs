
using System.Collections.Generic;
using UnityEngine;

public class Player :MonoBehaviour
{
    public Skill Target;

    public List<Skill> LearndSkills;
    private void Start()
    {
        CheckName(Target);
    }

    public void CheckName(Skill target)
    {
        if(target == null)
        {
            Debug.LogWarning("Target skill is null.");
            return;
        }

        SkillManager.Instance.NameOfSkill(target);
    }


}
