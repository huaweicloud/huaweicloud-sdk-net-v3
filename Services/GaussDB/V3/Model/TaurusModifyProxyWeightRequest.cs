using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// proxy实例修改权重请求体
    /// </summary>
    public class TaurusModifyProxyWeightRequest 
    {

        /// <summary>
        /// 主节点权重
        /// </summary>
        [JsonProperty("master_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? MasterWeight { get; set; }

        /// <summary>
        /// 只读节点权重配置信息
        /// </summary>
        [JsonProperty("readonly_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyProxyWeightReadonlyNode> ReadonlyNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaurusModifyProxyWeightRequest {\n");
            sb.Append("  masterWeight: ").Append(MasterWeight).Append("\n");
            sb.Append("  readonlyNodes: ").Append(ReadonlyNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaurusModifyProxyWeightRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaurusModifyProxyWeightRequest input)
        {
            if (input == null) return false;
            if (this.MasterWeight != input.MasterWeight || (this.MasterWeight != null && !this.MasterWeight.Equals(input.MasterWeight))) return false;
            if (this.ReadonlyNodes != input.ReadonlyNodes || (this.ReadonlyNodes != null && input.ReadonlyNodes != null && !this.ReadonlyNodes.SequenceEqual(input.ReadonlyNodes))) return false;

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
                if (this.MasterWeight != null) hashCode = hashCode * 59 + this.MasterWeight.GetHashCode();
                if (this.ReadonlyNodes != null) hashCode = hashCode * 59 + this.ReadonlyNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
