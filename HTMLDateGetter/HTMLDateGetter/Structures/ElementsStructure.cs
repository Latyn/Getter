using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDateGetter.Structures
{
    public struct QueryStructure
    {
        public string TableName;//Name of table
        public string TableIdName;//Identifier name on table
        public string TableField;//Field that is going to be checked
        public string Regex;//Regex for getting value
        public string QueryWhere;
    }

    public struct GottenItem
    {
        public string Value { get; set; }
        public int Id { get; set; }
    }
}
