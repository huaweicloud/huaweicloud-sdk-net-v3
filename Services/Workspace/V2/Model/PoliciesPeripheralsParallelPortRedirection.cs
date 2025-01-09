using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 并口重定向。
    /// </summary>
    public class PoliciesPeripheralsParallelPortRedirection 
    {

        /// <summary>
        /// 是否开启并口重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("parallel_port_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParallelPortEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsParallelPortRedirection {\n");
            sb.Append("  parallelPortEnable: ").Append(ParallelPortEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsParallelPortRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsParallelPortRedirection input)
        {
            if (input == null) return false;
            if (this.ParallelPortEnable != input.ParallelPortEnable || (this.ParallelPortEnable != null && !this.ParallelPortEnable.Equals(input.ParallelPortEnable))) return false;

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
                if (this.ParallelPortEnable != null) hashCode = hashCode * 59 + this.ParallelPortEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
