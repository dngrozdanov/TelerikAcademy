namespace PokemonTrainer
{
    public class Pokemon
    {
        private string _name;
        private string _element;
        private int _health;

        public string Name { get { return this._name; } set { this._name = value; }}
        public string Element { get { return this._element; } set { this._element = value; }}
        public int Health { get { return this._health; } set { this._health = value; }}

        public Pokemon(string name, string element, int health)
        {
            _name = name;
            _element = element;
            _health = health;
        }
    }
}
