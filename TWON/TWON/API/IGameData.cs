namespace TWON.API
{
	public interface IGameData
	{
		string Save();

		IGameData Load(string data);
	}
}
