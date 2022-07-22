using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CAdmin_ConstellationViewModel
    {

        private Constellation _con;
        public CAdmin_ConstellationViewModel()
        {
            _con = new Constellation();
        }
        public Constellation constellation
        {
            get { return _con; }
            set { _con = value; }
        }
        public int ConstellationId
        {
            get { return _con.ConstellationId; }
            set { _con.ConstellationId = value; }
        }
        public string ConstellationName
        {
            get { return _con.ConstellationName; }
            set { _con.ConstellationName = value; }
        }
        public int? ConstellationProductId
        {
            get { return _con.ConstellationProductId; }
            set { _con.ConstellationProductId = value; }
        }
    }
}
