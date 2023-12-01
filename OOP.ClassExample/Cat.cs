namespace OOP.ClassExample
{
    public class Cat
    {
        private string _name;

        public string GetName()
        {
            if (string.IsNullOrEmpty(_name))
            {
                return "A cicának még nincs neve.";
            }
            else
            {
                return $"A cica neve: {_name}.";
            }
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                _name = name;
            }
        }
    }
}
