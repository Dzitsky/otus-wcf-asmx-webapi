namespace AsmxApplicationService
{
    [System.Serializable]
    public class Individual
    {
        private int _operationResult;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public int SomeImportantAndPrivateOperation
        {
            get { return _operationResult; }
            set { _operationResult = value; }
        }

        public Individual() { }

        public Individual(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}