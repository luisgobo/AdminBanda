using System.Windows.Input;

namespace AdminBanda.Entidades
{
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public ICommand Command { get; set; }
    }
}