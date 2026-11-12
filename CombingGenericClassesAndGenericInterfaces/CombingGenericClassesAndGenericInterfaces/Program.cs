namespace ConstraintsForGenericInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    internal interface IEntity
    {
        int Id { get; }
    }
    internal interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }
    internal class Product : IEntity
    {
        public int Id { get; set; } // Already implement Id from IEntity
        public string Name { get; set; }
    }
    internal class User : IEntity
    {
        public string Name { get; set; }

        public int Id { get; }
    }
    /*
    internal class ProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }

    }
    internal class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {

        }
        public void Remove(User entity)
        {

        }

    }
    */

    //ลดการซ้ำซ้อนของ UserRepository และ ProductRepository ด้วย Repository<T>
    internal class Repository<T> : IRepository<T>
    {
        public void Add(T entity)
        {

        }
        public void Remove(T entity)
        {

        }

    }
}
