using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEnterpriseOrganizationsRequest 
    {

        /// <summary>
        /// 是否递归查询。0：不递归（默认）1：递归如果不递归，只返回起始节点的直接子节点。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("recursive_query", IsQuery = true)]
        [JsonProperty("recursive_query", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecursiveQuery { get; set; }

        /// <summary>
        /// 指定的节点ID。为空则从根节点查起。此参数不携带或携带值为空时，不作为筛选条件。 说明： 此参数须由纯数字组成。
        /// </summary>
        [SDKProperty("parent_id", IsQuery = true)]
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseOrganizationsRequest {\n");
            sb.Append("  recursiveQuery: ").Append(RecursiveQuery).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseOrganizationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseOrganizationsRequest input)
        {
            if (input == null) return false;
            if (this.RecursiveQuery != input.RecursiveQuery || (this.RecursiveQuery != null && !this.RecursiveQuery.Equals(input.RecursiveQuery))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.RecursiveQuery != null) hashCode = hashCode * 59 + this.RecursiveQuery.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
