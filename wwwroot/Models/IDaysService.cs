namespace Enterprise_Applications_Development_1_CA3.wwwroot.Models
{
    public interface IDaysService
    {
        Task<list<UsersDays>> GetDays();
    }
}
