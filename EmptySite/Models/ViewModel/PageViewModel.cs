using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptySite.Models.ViewModel
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public T CurrentPage { get; }

        public LayoutModel Layout { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Layout = new LayoutModel();
        }
    }
}