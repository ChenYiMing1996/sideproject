using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_exit_event : UI_checkboard_base {
	
	override public void active(GameObject gbj)
	{
			gbj.GetComponent<Checkerboard> ()._return ();
	}
	override public void relive()
	{
	}
}
