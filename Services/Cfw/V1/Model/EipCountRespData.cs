using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// EIP 数量查询反馈
    /// </summary>
    public class EipCountRespData 
    {

        /// <summary>
        /// 总体EIP数
        /// </summary>
        [JsonProperty("eip_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipTotal { get; set; }

        /// <summary>
        /// 该账号下所有墙防护EIP总数量
        /// </summary>
        [JsonProperty("eip_protected", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipProtected { get; set; }

        /// <summary>
        /// 当前防火墙防护EIP数量
        /// </summary>
        [JsonProperty("eip_protected_self", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipProtectedSelf { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipCountRespData {\n");
            sb.Append("  eipTotal: ").Append(EipTotal).Append("\n");
            sb.Append("  eipProtected: ").Append(EipProtected).Append("\n");
            sb.Append("  eipProtectedSelf: ").Append(EipProtectedSelf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipCountRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipCountRespData input)
        {
            if (input == null) return false;
            if (this.EipTotal != input.EipTotal || (this.EipTotal != null && !this.EipTotal.Equals(input.EipTotal))) return false;
            if (this.EipProtected != input.EipProtected || (this.EipProtected != null && !this.EipProtected.Equals(input.EipProtected))) return false;
            if (this.EipProtectedSelf != input.EipProtectedSelf || (this.EipProtectedSelf != null && !this.EipProtectedSelf.Equals(input.EipProtectedSelf))) return false;

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
                if (this.EipTotal != null) hashCode = hashCode * 59 + this.EipTotal.GetHashCode();
                if (this.EipProtected != null) hashCode = hashCode * 59 + this.EipProtected.GetHashCode();
                if (this.EipProtectedSelf != null) hashCode = hashCode * 59 + this.EipProtectedSelf.GetHashCode();
                return hashCode;
            }
        }
    }
}
