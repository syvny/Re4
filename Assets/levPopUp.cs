using UnityEngine;
using UnityEngine.UI;

public partial class levPopUp : MonoBehaviour
{
    public GameObject panel;
    
    public Button button;

    

    void Update()
    {
        Player player = Player.localPlayer;
        GameObject evelRestriction = GameObject.Find("Level Restriction Level 1");

        LevelCap Cap = evelRestriction.GetComponent<LevelCap>();

        int Currentlevel = Cap.levelCap;

        if (player != null && player.inLevelRes == true)
        {
            if(player.level<Currentlevel){
                panel.SetActive(true);
                player.CmdMoveBack();
            
                button.onClick.SetListener(() => {  panel.SetActive(false); player.inLevelRes = false; });
            }
            else{
                panel.SetActive(false);
            }

        }
        else panel.SetActive(false);

       
    }
}
