namespace Shopping.Web.Models.Ordering;

public class PaginatedResult<TEntity>(int pageIndex, int pagesize, long count, IEnumerable<TEntity> data)
    where TEntity : class 
{
    public int PageIndex { get; } = pageIndex;
    public int PageSize { get; } = pagesize;
    public long Count { get; } = count;
    public IEnumerable<TEntity> Data { get; } = data;
}
