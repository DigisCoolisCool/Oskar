using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() 
	{
		Speech.AddDialogue("0", "Oi", "1");
		Speech.AddDialogue("1", "hi", "2");
		Speech.AddDialogue("2", "good luck");
	
			}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other )
	{
		Speech.SetDialogue("0");
	}
}