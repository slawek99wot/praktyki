namespace Engine
{
    internal class MessageEventArgs
    {
        private bool addExtraNewLine;
        private string message;

        public MessageEventArgs(string message, bool addExtraNewLine)
        {
            this.message = message;
            this.addExtraNewLine = addExtraNewLine;
        }
    }
}