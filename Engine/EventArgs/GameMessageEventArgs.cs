namespace Engine.EventArgs
{
    public class GameMessageEventArgs
    {
        public string Message { get; set; }

        public GameMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
