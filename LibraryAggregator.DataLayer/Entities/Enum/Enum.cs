namespace LibraryAggregator.DataLayer.Entities.Enum
{
    public enum BookingStatuses : int
    {
        Free = 1,  // Готова для бронирования 
        Booked = 2, // Забронированная книга
        Cancell = 3, // Отмена бронирования
        GivenClient = 4, // Отдана клиенту
        Returned = 5 // Возвращена клиенту
    }

}
