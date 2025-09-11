using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListReadonlyNodesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 只读节点列表。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListReadonlyNodesResult> Instances { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("max_readonly_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReadonlyNodeNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReadonlyNodesResponse {\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  maxReadonlyNodeNum: ").Append(MaxReadonlyNodeNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReadonlyNodesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReadonlyNodesResponse input)
        {
            if (input == null) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.MaxReadonlyNodeNum != input.MaxReadonlyNodeNum || (this.MaxReadonlyNodeNum != null && !this.MaxReadonlyNodeNum.Equals(input.MaxReadonlyNodeNum))) return false;

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
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.MaxReadonlyNodeNum != null) hashCode = hashCode * 59 + this.MaxReadonlyNodeNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
