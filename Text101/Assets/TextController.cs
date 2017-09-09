using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, 
						 stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, corridor_2,
						 stairs_2, corridor_3, courtyard};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {state_cell ();}
		else if (myState == States.sheets_0) 	{state_sheets_0 ();} 
		else if (myState == States.mirror) 		{state_mirror ();} 
		else if (myState == States.lock_0) 		{state_lock_0 ();} 
		else if (myState == States.cell_mirror) {state_cell_mirror ();} 
		else if (myState == States.sheets_1) 	{state_sheets_1 ();} 
		else if (myState == States.lock_1) 		{state_lock_1();}
  		else if (myState == States.corridor_0) 	{state_corridor_0();}
		else if (myState == States.corridor_1) 	{state_corridor_1();}
		else if (myState == States.corridor_2) 	{state_corridor_2();}
		else if (myState == States.corridor_3) 	{state_corridor_3();}
		else if (myState == States.stairs_0) 	{state_stairs_0();}
		else if (myState == States.stairs_1) 	{state_stairs_1();}
		else if (myState == States.stairs_2) 	{state_stairs_2();}
		else if (myState == States.floor) 		{state_floor();}
		else if (myState == States.closet_door) {state_closet_door();}
	 	else if (myState == States.in_closet) 	{state_in_closet();}
		else if (myState == States.courtyard) 	{state_courtyard();}
	}
	void state_cell(){
		text.text = "You're in a prison cell, and you want to escape. " +
					"There are some dirty sheets on the bed, a mirror " +
					"on the wall, and your cell door with a lock.\n\n"  +
					"Press S to view the Sheets, M to view the Mirror " +
					"and L to view the Lock.";
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.sheets_0;}
		if (Input.GetKeyDown (KeyCode.M)) {myState = States.mirror;}
		if (Input.GetKeyDown (KeyCode.L)) {myState = States.lock_0;}
	}
	void state_sheets_0(){
		text.text = "You can't believe you sleep in these things. Surely " +
					"it's time somebody changed them. The pleasures of pr" +
					"ison life I guess. \n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.cell;}
	}
	void state_mirror(){
		text.text = "Not sure if this small grimy thing can be called a mirror " +
					"but you think you can see your reflection on its sur" +
					"face. It looks removable. \n\n" +
					"Press R to Return to roaming your cell or T to take the mirror.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.cell;}
		if (Input.GetKeyDown (KeyCode.T)) {myState = States.cell_mirror;}
	}
	void state_lock_0(){
		text.text = "A pretty standard prison lock with a keyhole on the outside. If " +
					"only you could see inside it, you might be able to pick the lock" +
					" and open the door. \n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.cell;}
	}
	void state_cell_mirror(){
		text.text = "You are now holding the mirror, not sure why, but you are. \n\n" +
					"Press S to view the Sheets or L to view the Lock.";
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.sheets_1;}
		if (Input.GetKeyDown (KeyCode.L)) {myState = States.lock_1;}
	}
	void state_sheets_1(){
		text.text = "Yup... still dirty.... \n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.cell_mirror;}
	}
	void state_lock_1(){
		text.text = "With the mirror in hand, you might be able to see the other side " +
					" of the lock.\n\n" +
					"Press R to Return to roaming your cell or O to Open the lock.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.cell_mirror;}
		if (Input.GetKeyDown (KeyCode.O)) {myState = States.corridor_0;}
	}
	void state_corridor_0(){
		text.text = "You did it! You're out of your cell and in the corridor, " +
					"but now what are you going to do?\n\n" +
					"Press S to investigate the Stairs, F to look around on the " +
					"Floor, or C to investigate the Closet";
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.stairs_0;}
		if (Input.GetKeyDown (KeyCode.F)) {myState = States.floor;}
		if (Input.GetKeyDown (KeyCode.C)) {myState = States.closet_door;}
	}
	void state_stairs_0(){
		text.text = "These stairs lead to the courtyard, probably shouldn't take " +
					"them unless you want to be seen.\n\n" +
					"Press R to Return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_0;}
	}
	void state_floor(){
		text.text = "You look around on the floor for something you can use " +
					"and you find a hairpin!\n\n" +
					"Press H to take the Hairpin or R to Return to the corridor.";
		if (Input.GetKeyDown (KeyCode.H)) {myState = States.corridor_1;}
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_0;}
	}
	void state_closet_door(){
		text.text = "This looks like a janitorial closet, but its locked.\n\n" +
					"Press R to Return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_0;}
	}
	void state_corridor_1(){
		text.text = "You are now hairpin in hand.\n\n" +
					"Press S to investigate the Stairs or P to Pick the lock " +
					"on the closet door.";
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.stairs_1;}
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.in_closet;}
	}
	void state_stairs_1(){
		text.text = "Still need to solve the problem of beeing seen in a bright " +
					"orange jumpsuit after hours...\n\n" +
					"Press R to Return to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_1;}
	}
	void state_in_closet(){
		text.text = "You are now in a closet full of cleaning supplies and janitor " +
					"uniforms.\n\n" +
					"Press R to Return to the corridor or D to Dress in the uniform.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_2;}
		if (Input.GetKeyDown (KeyCode.D)) {myState = States.corridor_3;}
	}
	void state_corridor_2(){
		text.text = "You hop out of the closet and are back in the corridor.\n\n" +
					"Press B to hop Back in the closet or S to investigate the Stairs";
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.stairs_2;}
		if (Input.GetKeyDown (KeyCode.B)) {myState = States.in_closet;}
	}
	void state_stairs_2(){
		text.text = "You see guards all around the courtyard and a few janitors " +
					"walking about, but no inmates, better stay low.\n\n" +
					"Press R to Return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_2;}
	}
	void state_corridor_3(){
		text.text = "You step out of the closet looking pretty dapper in that janitors uniform.\n\n" +
					"Press U to hop back into the closet to Undress or S to investigate the Stairs";
		if (Input.GetKeyDown (KeyCode.U)) {myState = States.in_closet;}
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.courtyard;}
	}
	void state_courtyard(){
		text.text = "You walk up the stairs wearing the uniform of a janitor, " +
					"and no one seems to notice you. You head for the door and slip out " +
					"into the night on your way to freedom! Well Done!! \n\n" +
					"Press P to Play again.";
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.cell;}
	}
}
