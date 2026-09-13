namespace BigLion.Application.Common.Interfaces
{

    /// <summary>
    /// บริการสำหรับ
    /// </summary>
    public interface IPublicCheckupService
    {
        Task GetCheckupResult(string hospitalNumber);
    }
}
