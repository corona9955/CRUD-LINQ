using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_LINQ
{
    public class DataBaseServices
    {
        DataModelDataContext DataModelDataContext = new DataModelDataContext();

        public List<Users> GetList()
        {
            List<Users> users = new List<Users>();
            return users = DataModelDataContext.Users.ToList();
        }
        public Users GetOne(int id)
        {
            return DataModelDataContext.Users.SingleOrDefault(usr => usr.idUser == id);
        }
        public void Insert(Users users)
        {
            DataModelDataContext.Users.InsertOnSubmit(users);
            DataModelDataContext.SubmitChanges();
        }

        public void Update(Users users)
        {
            Users objectUserUpdate = new Users();
            objectUserUpdate = DataModelDataContext.Users.SingleOrDefault(usr => usr.idUser == users.idUser);
            objectUserUpdate.idUser = users.idUser;
            objectUserUpdate.Firtname = users.Firtname;
            objectUserUpdate.lastname = users.lastname;
            objectUserUpdate.INE = users.INE;
            DataModelDataContext.SubmitChanges();      
        }

        public void Delete(int id)
        {
            Users objetUserDelete = new Users();
            objetUserDelete = DataModelDataContext.Users.SingleOrDefault(usr => usr.idUser == id);
            DataModelDataContext.Users.DeleteOnSubmit(objetUserDelete);
            DataModelDataContext.SubmitChanges();
        }

       
    }
}
