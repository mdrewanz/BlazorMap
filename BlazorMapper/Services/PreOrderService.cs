using AutoMapper;
using BlazorMapper.Data;
using BlazorMapper.Models;

namespace BlazorMapper.Services
{
    public class PreOrderService : IPreOrderService
    {
        private readonly IMapper mapper;

        public PreOrderService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public PreOrderDto GetPreOrder()
        {
            var entity = new PreOrder();

            var model = mapper.Map<PreOrderDto>(entity);

            return model;
        }

        public void SetPreOrder(PreOrderDto model)
        {
            var entity = mapper.Map<PreOrder>(model);
        }
    }
}
