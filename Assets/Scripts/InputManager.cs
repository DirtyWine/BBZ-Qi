﻿using System;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace TurnBase
{
    public class InputManager : MonoBehaviour
    {
        #region Private Field

        private PunTurnManager pPunTurnManager;

        private Action.Type lastInput;
        #endregion


        #region Public Methods

        public void Initialize(PunTurnManager turnManager)
        {
            this.pPunTurnManager = turnManager;
            Debug.Assert(pPunTurnManager != null);

            ResetInput();
        }


        public void ResetInput()
        {
            lastInput = Action.Type.None;
        }

        public void OnClickAttack()
        {
            if (lastInput != Action.Type.Attack)
            {
                this.pPunTurnManager.SendMove(Action.Type.Attack, false);
                lastInput = Action.Type.Attack;
            }
        }
        public void OnClickUltiAttack()
        {
            if (lastInput != Action.Type.SuperAttack)
            {
                this.pPunTurnManager.SendMove(Action.Type.SuperAttack, false);
                lastInput = Action.Type.SuperAttack;
            }
        }

        public void OnClickCharge()
        {
            if (lastInput != Action.Type.Charge)
            {
                this.pPunTurnManager.SendMove(Action.Type.Charge, false);
                lastInput = Action.Type.Charge;
            }

        }

        public void OnClickDefend()
        {
            if (lastInput != Action.Type.Defend)
            {
                this.pPunTurnManager.SendMove(Action.Type.Defend, false);
                lastInput = Action.Type.Defend;
            }
        }
        public void OnClickBack()
        {
            PhotonNetwork.LeaveRoom();
        }

        #endregion

        #region MonoBehaviour Callback

        void Start()
        {

        }

        void Update()
        {

            //if (!this.pPunTurnManager.IsFinishedByMe)
            //{
            //    if (Input.GetKeyDown(KeyCode.A) && lastInput != Action.Type.Attack) 
            //    {
            //        this.pPunTurnManager.SendMove(Action.Type.Attack, false);
            //        lastInput = Action.Type.Attack;
            //    }

            //    if (Input.GetKeyDown(KeyCode.D) && lastInput != Action.Type.Defend)
            //    {
            //        this.pPunTurnManager.SendMove(Action.Type.Defend, false);
            //        lastInput = Action.Type.Defend;
            //    }

            //    if (Input.GetKeyDown(KeyCode.Space) && lastInput != Action.Type.Charge)
            //    {
            //        this.pPunTurnManager.SendMove(Action.Type.Charge, false);
            //        lastInput = Action.Type.Charge;
            //    }
            //}
        }

        #endregion
    }
}

