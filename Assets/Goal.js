#pragma strict

private var cleared : boolean;
var aTexture : Texture;

function Start () {
	cleared = false;
}

function Update () {

}

function OnTriggerEnter ( other : Collider )
{
	if ( other.gameObject.tag == "Lob" )
	{
		if ( cleared == false )
		{
			cleared = true;
			yield WaitForSeconds(2.0);
			Application.LoadLevel("stage2");
		}
	}
}

function OnGUI()
{
	if ( cleared == true)
	{
		Debug.Log("cleared true! clear!!");
		var sw : int = Screen.width;
		var sh : int = Screen.height;
		//GUI.Label(Rect( sw / 6, sh / 3, sw * 2 / 3, sh / 3 ), "CLEARED!!" );
		GUI.DrawTexture(Rect( sw * 0.1, sh * 0.4 , sw * 0.8, sh * 0.2), aTexture, ScaleMode.ScaleToFit, true, 10.0f);
	}
}