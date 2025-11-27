using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class L4Limit 
    {

        /// <summary>
        /// **参数解释**：负载均衡实例的四层规格的最大并发连接数限速值。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡实例的四层规格的每秒新建连接数限速值。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class L4Limit {\n");
            sb.Append("  connection: ").Append(Connection).Append("\n");
            sb.Append("  cps: ").Append(Cps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as L4Limit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(L4Limit input)
        {
            if (input == null) return false;
            if (this.Connection != input.Connection || (this.Connection != null && !this.Connection.Equals(input.Connection))) return false;
            if (this.Cps != input.Cps || (this.Cps != null && !this.Cps.Equals(input.Cps))) return false;

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
                if (this.Connection != null) hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.Cps != null) hashCode = hashCode * 59 + this.Cps.GetHashCode();
                return hashCode;
            }
        }
    }
}
