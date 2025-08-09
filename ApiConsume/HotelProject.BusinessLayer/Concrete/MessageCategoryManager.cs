using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TDelete(MessageCategoy t)
        {
            throw new NotImplementedException();
        }

        public MessageCategoy TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageCategoy> TGetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void TInsert(MessageCategoy t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MessageCategoy t)
        {
            throw new NotImplementedException();
        }
    }
}
