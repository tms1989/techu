using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class RPC_Controller : MonoBehaviour
{   
   private PhotonView PV;
   public int currentSpaceNumberRPC;
   public int redDeckNotYetDealt;
   public int blackDeckNotYetDealt;
   public int currentSpaceNumber;

    /*void Start(){
        PV= GetComponent<PhotonView>();
    }

    void Update(){
        txtNumber.text="Number to Increase: "+globalNumber;
    }
           */

    [PunRPC]
    void RPC_UpdateCurrentSpaceNumber(){
        currentSpaceNumberRPC++;
    }

    [PunRPC]
    void RPC_ResetCurrentSpaceNumber()
    {
        currentSpaceNumberRPC = 0;
    }

    [PunRPC]
    void RPC_UpdateRedDeckNotYetDealt()
    {
        redDeckNotYetDealt--;
    }

    [PunRPC]
    void RPC_UpdateBlackDeckNotYetDealt()
    {
        blackDeckNotYetDealt--;
    }
}
