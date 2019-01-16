using EPiServer.Core;

namespace EmptySite.Models.ViewModel
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; }
    }
}