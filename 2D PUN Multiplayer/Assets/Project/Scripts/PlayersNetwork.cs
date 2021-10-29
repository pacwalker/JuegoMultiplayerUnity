using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayersNetwork : MonoBehaviour
{
    public MonoBehaviour[] ignoreCodes;

    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            foreach (var code in ignoreCodes)
            {
                code.enabled=false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
