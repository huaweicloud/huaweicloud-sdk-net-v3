using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PriorityBody 
    {

        /// <summary>
        /// 副本优先级，取值范围是0到100，0为默认禁止倒换。
        /// </summary>
        [JsonProperty("slave_priority_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlavePriorityWeight { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriorityBody {\n");
            sb.Append("  slavePriorityWeight: ").Append(SlavePriorityWeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PriorityBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PriorityBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SlavePriorityWeight == input.SlavePriorityWeight ||
                    (this.SlavePriorityWeight != null &&
                    this.SlavePriorityWeight.Equals(input.SlavePriorityWeight))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SlavePriorityWeight != null)
                    hashCode = hashCode * 59 + this.SlavePriorityWeight.GetHashCode();
                return hashCode;
            }
        }
    }
}
