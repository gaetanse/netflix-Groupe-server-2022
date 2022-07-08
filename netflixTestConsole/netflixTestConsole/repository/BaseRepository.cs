namespace BankEntityFrameWork.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected BaseRepository(){ }
        public abstract bool Create(T element);
        public abstract bool Update(T element); //est ce que c'est utile ? vu que si on save ca update
        public abstract bool Remove(int id);
        public abstract T FindById(int id);
        public abstract T FindBy(Predicate<T> predicate);
        public abstract List<T> FindAll();
        public abstract List<T> FindAllBy(Predicate<T> predicate);
    }
}
