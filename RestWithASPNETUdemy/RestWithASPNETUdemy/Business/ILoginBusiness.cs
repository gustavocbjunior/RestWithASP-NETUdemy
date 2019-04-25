using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(UserVO user);
    }
}
