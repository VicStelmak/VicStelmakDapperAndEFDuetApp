namespace VicStelmak.DEFDA.Application.Interfaces_Dapper
{
    public interface ISqlDbAccessDapper
    {
        Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters);
        Task SaveDataAsync<T>(string storedProcedure, T parameters);
    }
}