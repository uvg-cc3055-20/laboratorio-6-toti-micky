using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{

	private VirtualButtonBehaviour virtualBtn;
	public Animator birdAnim;

	private void Start()
	{
		virtualBtn = GetComponent<VirtualButtonBehaviour>(); 
		virtualBtn.RegisterEventHandler(this);
	}

	private void update()
	{
		
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		birdAnim.SetTrigger("sing");
	}
	
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		
	}
	
}
