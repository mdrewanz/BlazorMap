using BlazorMapper.Models;
using BlazorMapper.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorMapper.Pages
{
    public partial class TestMap : ComponentBase
    {
        [Inject]
        public IPreOrderService service { get; set; }

        private PreOrderDto preOrder;

        protected override async Task OnParametersSetAsync()
        {
            // return base.OnParametersSetAsync();
            preOrder = service.GetPreOrder();
        }
    }
}
