namespace MailClient
{
    using System.Text;

    public class MailBox
    {
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public void IncomingMail(Mail mail)
        {
            if(Inbox.Count < Capacity) Inbox.Add(mail);
        }

        public bool DeleteMail(string sender)
        {
            foreach(Mail mail in Inbox)
            {
                if(mail.Sender == sender)
                {
                    Inbox.Remove(mail);
                    return true;
                }
            }
            return false;
        }

        public int ArchiveInboxMessages()
        {
            foreach(Mail mail in Inbox) Archive.Add(mail);
            Inbox.Clear();
            return Archive.Count();
        }

        public string GetLongestMessage()
        {
            Mail longestMail = new Mail("", "", "");
            int longestLength = -1;
            foreach(Mail mail in Inbox)
            {
                if(mail.Body.Length >= longestLength)
                {
                    longestMail = mail;
                    longestLength = mail.Body.Length;
                }
            }
            return longestMail.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Inbox:");
            foreach(Mail mail in Inbox) sb.Append($"\n{mail.ToString()}");
            return sb.ToString();
        }
    }
}