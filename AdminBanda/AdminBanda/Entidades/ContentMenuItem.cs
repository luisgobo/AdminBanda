using System.Windows.Input;

namespace AdminBanda.Entidades
{
    public class ContentMenuItem
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public ICommand Command { get; set; }
    }
}