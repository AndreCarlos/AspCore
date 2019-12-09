namespace asp8.ViewModel
{
    public class Humano
    {
        public string nome { get; set; }
        public string apelido { get; set; }
    }

    public class Automovel
    {
        public string marca { get; set; }
        public string cor { get; set; }
    }

    public class Bag
    {
        public Humano humano { get; set; }
        public Automovel automovel { get; set; }
    }
}