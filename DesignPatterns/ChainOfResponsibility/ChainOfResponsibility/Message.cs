namespace ChainOfResponsibility
{
    public struct Message
    {
        public Message(int number, string info)
        {
            this.number = number;
            this.info = info;
        }

        public int number { get; set; }
        public string info { get; set; }
    }
}