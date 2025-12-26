namespace SampleAttribute
{

    [AttributeUsage(AttributeTargets.Class)]
   public class PKAttribute: Attribute
    {
        private string _CompanyName;
        private string _DeveloperName;

        public string CompanyName {
            get { return _CompanyName; } 
            set => _CompanyName=value; 
        }
        public string DeveloperName {
            get { return _DeveloperName; } 
            set => _DeveloperName=value;
        }
    }
}
