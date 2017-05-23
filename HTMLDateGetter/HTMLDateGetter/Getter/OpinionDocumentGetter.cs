using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTMLDateGetter.Structures;

namespace HTMLDateGetter.Getter
{
    class OpinionDocumentGetter:AbsValueGetter
    {

        public OpinionDocumentGetter()
        {
            
        }

        public override void workWithElements()
        {
            QueryStructure query = new QueryStructure();

            query.TableIdName = "OpinionDocuments";
            query.TableField =  "Html";
            query.TableField =  "OpinionDocumentId";
            query.QueryWhere = "OpinionDocuments.Date<'01-01-1700'";

            GetElementFromDB(query);
        }
    }
}
