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
    /// Response Object
    /// </summary>
    public class ListEnterpriseOrganizationsResponse : SdkResponse
    {

        /// <summary>
        /// 根节点ID，如果请求有parent_id，则该参数无值。
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }

        /// <summary>
        /// 根节点名称，如果请求有parent_id，则该参数无值。  说明： 组织根节点没有设置组织名称时，可能为空。
        /// </summary>
        [JsonProperty("root_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RootName { get; set; }

        /// <summary>
        /// 子节点列表。
        /// </summary>
        [JsonProperty("child_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<EmChildNodeV2> ChildNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseOrganizationsResponse {\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("  rootName: ").Append(RootName).Append("\n");
            sb.Append("  childNodes: ").Append(ChildNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseOrganizationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseOrganizationsResponse input)
        {
            if (input == null) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;
            if (this.RootName != input.RootName || (this.RootName != null && !this.RootName.Equals(input.RootName))) return false;
            if (this.ChildNodes != input.ChildNodes || (this.ChildNodes != null && input.ChildNodes != null && !this.ChildNodes.SequenceEqual(input.ChildNodes))) return false;

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
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                if (this.RootName != null) hashCode = hashCode * 59 + this.RootName.GetHashCode();
                if (this.ChildNodes != null) hashCode = hashCode * 59 + this.ChildNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
