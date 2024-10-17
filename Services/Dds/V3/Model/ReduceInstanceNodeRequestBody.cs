using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReduceInstanceNodeRequestBody 
    {

        /// <summary>
        /// 删除的节点数量。
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public int? Num { get; set; }

        /// <summary>
        /// 指定删除节点的ID列表。 - num与node_list必须有一个字段传值 - 如果num与node_list同时传值时，则以node_list的值为主 - 删除的节点角色不能是Primary - 如果是多AZ实例，请确保删除节点后，每个AZ至少保留一个节点
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceInstanceNodeRequestBody {\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReduceInstanceNodeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReduceInstanceNodeRequestBody input)
        {
            if (input == null) return false;
            if (this.Num != input.Num || (this.Num != null && !this.Num.Equals(input.Num))) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && input.NodeList != null && !this.NodeList.SequenceEqual(input.NodeList))) return false;

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
                if (this.Num != null) hashCode = hashCode * 59 + this.Num.GetHashCode();
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
