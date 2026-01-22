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
    /// 
    /// </summary>
    public class EipBypassDto 
    {

        /// <summary>
        /// 防护操作类型，1表示一键关闭防护，0表示一键恢复防护
        /// </summary>
        [JsonProperty("bypass_operation", NullValueHandling = NullValueHandling.Ignore)]
        public int? BypassOperation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipBypassDto {\n");
            sb.Append("  bypassOperation: ").Append(BypassOperation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipBypassDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipBypassDto input)
        {
            if (input == null) return false;
            if (this.BypassOperation != input.BypassOperation || (this.BypassOperation != null && !this.BypassOperation.Equals(input.BypassOperation))) return false;

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
                if (this.BypassOperation != null) hashCode = hashCode * 59 + this.BypassOperation.GetHashCode();
                return hashCode;
            }
        }
    }
}
