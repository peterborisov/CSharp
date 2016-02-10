namespace RestaurantManager.Interfaces
{
    using RestaurantManager.Models;

    public interface IMainCourse : IMeal
    {
        string Type { get; }
    }
}