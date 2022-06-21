using BlazorMapper.Models;

namespace BlazorMapper.Services
{
    public interface IPreOrderService
    {
        PreOrderDto GetPreOrder();
        void SetPreOrder(PreOrderDto model);
    }
}