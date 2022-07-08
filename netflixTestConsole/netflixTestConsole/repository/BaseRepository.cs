namespace BankEntityFrameWork.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected BaseRepository(){ }
        public abstract bool Create(T element);
        public abstract bool Remove(int id);
        public abstract T FindById(int id);
        public abstract List<T> FindAll();
    }
}
