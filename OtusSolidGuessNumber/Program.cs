namespace OtusSolidGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStore _gameStore = new GameStore(new GueesReader(), new GueesValidator(), new GueesGenerate());
            _gameStore.Executor();
        }
    }
}
