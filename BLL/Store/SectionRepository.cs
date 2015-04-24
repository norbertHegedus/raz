using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL.Store
{
    public class SectionRepository
    {
        #region " BLL/DAL Methods "

        public  Section AddSection(Section vSection)
        {
            try
            {
                if (vSection.EntityState == EntityState.Detached)
                {
                    return null; 
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        #endregion
    }

}
