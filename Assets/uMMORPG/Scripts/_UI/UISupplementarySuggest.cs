// Note: this script has to be on an always-active UI parent, so that we can
// always find it from other code. (GameObject.Find doesn't find inactive ones)
using UnityEngine;
using UnityEngine.UI;

public partial class UISupplementarySuggest : MonoBehaviour
{
    public GameObject panel;
    
    public Button button;

    

    void Update()
    {
        Player player = Player.localPlayer;

        // show while player is dead
       if(player != null && player.health == 0 && player.activeQuestLimit>0 ){
           
           
           panel.SetActive(true);
           button.onClick.SetListener(() => { panel.SetActive(false); });
       }

       
    }
}
