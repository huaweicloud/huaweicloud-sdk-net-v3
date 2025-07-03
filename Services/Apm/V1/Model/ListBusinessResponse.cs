using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBusinessResponse : SdkResponse
    {

        /// <summary>
        /// 获取应用列表数据结构。
        /// </summary>
        [JsonProperty("business_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<BusinessNodeModel> BusinessNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBusinessResponse {\n");
            sb.Append("  businessNodes: ").Append(BusinessNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBusinessResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBusinessResponse input)
        {
            if (input == null) return false;
            if (this.BusinessNodes != input.BusinessNodes || (this.BusinessNodes != null && input.BusinessNodes != null && !this.BusinessNodes.SequenceEqual(input.BusinessNodes))) return false;

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
                if (this.BusinessNodes != null) hashCode = hashCode * 59 + this.BusinessNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
