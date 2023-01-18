namespace HolidayInCity.DataAccess.Executors;

public class QueryExecutor : IQueryExecutor
{
    private readonly HolidayInCityDbContext context;

    public QueryExecutor(HolidayInCityDbContext context)
    {
        this.context = context;
    }
    public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
    {
        return query.Execute(this.context);
    }
}
