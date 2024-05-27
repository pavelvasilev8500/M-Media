using M_Media.ModelInterfaces;

namespace M_Media.ViewModels
{
    public class TextViewModel : IText
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}
