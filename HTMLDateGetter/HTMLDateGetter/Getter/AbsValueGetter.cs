using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTMLDateGetter.Structures;
using CaseLaw;

namespace HTMLDateGetter.Getter
{
    public abstract class AbsValueGetter
    {
 
        /// <summary>
        /// Get the elements from Db based on our parameters
        /// </summary>
        /// <param name="values"></param>
        public void GetElementFromDB(QueryStructure values)
        {
            using (var context = new CaseLaw.Data.CaseLawContext())
            {
                var results = context.Database.SqlQuery(typeof(GottenItem),
                    "select @tableColumn from @tableName where @queryWhere", 
                    new SqlParameter("@tableName", values.TableName), 
                    new SqlParameter("@tableName", values.TableName), 
                    new SqlParameter("@tableName", values.TableName));

            }
        }

        /// <summary>
        /// This will start our process after getting elements
        /// </summary>
        public abstract void workWithElements();
    }
}
