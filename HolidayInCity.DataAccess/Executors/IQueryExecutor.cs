namespace HolidayInCity.DataAccess.Executors;

public interface IQueryExecutor
{
    Task<TResult> Execute<TResult>(QueryBase<TResult> query);
}
