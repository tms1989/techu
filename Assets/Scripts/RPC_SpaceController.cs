using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class RPC_SpaceController : MonoBehaviour
{   
   private PhotonView PV;
   public int spaceRankRPC;

    /*void Start(){
        PV= GetComponent<PhotonView>();
    }

    void Update(){
        txtNumber.text="Number to Increase: "+globalNumber;
    }
           */

    [PunRPC]
    void RPC_UpdateSpaceRank(){
        spaceRankRPC++;
    }

    [PunRPC]
    void RPC_ResetSpaceRank()
    {
        spaceRankRPC = 0;
    }

}
