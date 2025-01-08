using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ProcessWithArguments.Data
{
    [DataContract]
    public class MailboxSettings
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool Enabled { get; set; }

        [DataMember]
        public string ShortcutName { get; set; }

        [DataMember]
        public string DestinationFolderName { get; set; }

        [DataMember]
        public bool MarkEmailsRead { get; set; }

        [DataMember]
        public int EmailsToProcess { get; set; }

        [DataMember]
        public string VRManagerEmailAddress { get; set; }

        [DataMember]
        public MailboxException Exception { get; set; }

        [DataMember]
        public Dictionary<string, string> DocControlFieldValues { get; set; }
    }
    
    [DataContract]
    public class MailboxException
    {
        [DataMember]
        public string ExceptionFolderName { get; set; }

        [DataMember]
        public List<string> SubjectStartsWith { get; set; }

        [DataMember]
        public List<string> SubjectEndsWith { get; set; }

        [DataMember]
        public List<SubjectException> SubjectExceptions { get; set; }

        [DataMember]
        public List<string> BodyContains { get; set; }

        [DataMember]
        public List<string> ExcludeAddresses { get; set; }

        [DataMember]
        public List<string> ExclusiveAddresses { get; set; }
    }
    
    [DataContract]
    public class SubjectException
    {
        [DataMember]
        public string Contains { get; set; }

        [DataMember]
        public string FromAddress { get; set; }
    }
}