namespace AsmxApplicationService
{
    [System.Serializable]
    public class Individual
    {
        private int _operationResult;
        private string _fullName;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                this._fullName = this.FirstName + " " + this.LastName;
                return this._fullName;
             }
            set { _fullName = value; }
        }

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