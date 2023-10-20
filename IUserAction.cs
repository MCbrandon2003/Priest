using System;


public interface IUserAction
{
	void GameOver();
	void MoveBoat(BoatModel boatModel);
	void MoveRole(RoleModel roleModel);
	void RestartGame();
}


