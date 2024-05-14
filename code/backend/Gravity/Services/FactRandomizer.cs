namespace Gravity.Services
{
    public class FactRandomizer
    {
        private readonly string[] _facts;

        public FactRandomizer(string[] facts)
        {
            _facts = facts;
        }

        public string GetRandomFact()
        {
            return _facts[Random.Shared.Next(0, _facts.Length)];
        }
    }
}
