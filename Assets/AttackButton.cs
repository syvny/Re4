using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Player player = Player.localPlayer;

         if (player != null)
        {
           

            // instantiate/destroy enough slots
           
            // refresh all
            for (int i = 0; i < player.skillbar.Length; ++i)
            {
        

                // skill, inventory item or equipment item?
                int skillIndex = player.GetSkillIndexByName(player.skillbar[i].reference);
                int inventoryIndex = player.GetInventoryIndexByName(player.skillbar[i].reference);
                int equipmentIndex = player.GetEquipmentIndexByName(player.skillbar[i].reference);
                if (skillIndex != -1)
                {
                    Skill skill = player.skills[skillIndex];
                    bool canCast = player.CastCheckSelf(skill);

                    // hotkey pressed and not typing in any input right now?
                    if (Input.GetKeyDown(player.skillbar[i].hotKey) &&
                        !UIUtils.AnyInputActive() &&
                        canCast) // checks mana, cooldowns, etc.) {
                    {
                        // try use the skill or walk closer if needed
                        player.TryUseSkill(skillIndex);
                    }

              
               
                }
  
            }
        }
     
    }


}
