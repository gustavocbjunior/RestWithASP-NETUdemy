using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        Person FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
