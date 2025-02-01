namespace BookShoppingCartMvcUI.Repositories;

public interface IUserOrderRepository
{
    Task<IEnumerable<Order>> UserOrders();
   // Task TogglePaymentStatus(int orderId);
    //Task<Order?> GetOrderById(int id);
   // Task<IEnumerable<OrderStatus>> GetOrderStatuses();

}