using Lojinha.Consumer.Web.Models;

namespace Lojinha.Consumer.Web.Services;

public interface IItemService
{
    public Task<IEnumerable<ItemModel>> FindAll();

    public Task<ItemModel> FindById(long id);

    public Task<bool> Delete(long id);

    public Task<ItemModel> Update(int id, ItemModel vo);

    public Task<ItemModel> Create(ItemModel vo);
}