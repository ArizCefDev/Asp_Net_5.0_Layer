using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            _writerDal.Delete(t);
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetByid(id);
        }

        public List<Writer> TGetList()
        {
            return _writerDal.GetListAll();
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }
    }
}
