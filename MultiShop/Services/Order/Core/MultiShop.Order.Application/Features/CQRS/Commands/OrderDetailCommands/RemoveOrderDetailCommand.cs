namespace MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands
{

    public class RemoveOrderDetailCommand
        {
            public int Id { get; set; }

            public RemoveOrderDetailCommand(int id)
            {
                Id = id;
            }
        }
    
}
