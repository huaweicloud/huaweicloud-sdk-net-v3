using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 规格信息
    /// </summary>
    public class QuerySupportNodeTypeBean 
    {

        /// <summary>
        /// 规格类型
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// 是否售罄
        /// </summary>
        [JsonProperty("is_sellout", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSellout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySupportNodeTypeBean {\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  isSellout: ").Append(IsSellout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuerySupportNodeTypeBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuerySupportNodeTypeBean input)
        {
            if (input == null) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.IsSellout != input.IsSellout || (this.IsSellout != null && !this.IsSellout.Equals(input.IsSellout))) return false;

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
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.IsSellout != null) hashCode = hashCode * 59 + this.IsSellout.GetHashCode();
                return hashCode;
            }
        }
    }
}
