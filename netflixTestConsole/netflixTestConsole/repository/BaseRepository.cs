namespace BankEntityFrameWork.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected BaseRepository(){ }
        public abstract bool Create(T element);
        public abstract bool Update(T element);
        public abstract T Find(Predicate<T> predicate);
        public abstract List<T> FindAll(Predicate<T> predicate);
    }
}
