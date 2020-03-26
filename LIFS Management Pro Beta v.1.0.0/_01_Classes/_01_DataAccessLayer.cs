using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFS_Management_Pro_Beta_v._1._0._0._01_Classes
{
    public class _01_DataAccessLayer
    {
        #region Database Connection

        public void DC()
        {
            _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();
        }

        #endregion
       

    }
}
