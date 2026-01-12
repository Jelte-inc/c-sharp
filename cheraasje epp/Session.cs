using CheraasjeEpp.Models.Filters;

public static class Session
{
    public static int UserId { get; private set; }

    public static CarFilter? CarFilter { get; set; }
    public static bool SafeLogin { get; set; }

    public static void Start(int userId)
    {
        UserId = userId;
    }

    public static void End()
    {
        UserId = 0; // of -1 als “geen gebruiker ingelogd”
    }
}
