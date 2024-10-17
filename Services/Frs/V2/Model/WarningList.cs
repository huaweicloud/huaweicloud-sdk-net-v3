using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WarningList 
    {

        /// <summary>
        /// 警告ID。
        /// </summary>
        [JsonProperty("warningCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? WarningCode { get; set; }

        /// <summary>
        /// 告警消息。
        /// </summary>
        [JsonProperty("warningMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string WarningMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarningList {\n");
            sb.Append("  warningCode: ").Append(WarningCode).Append("\n");
            sb.Append("  warningMsg: ").Append(WarningMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WarningList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WarningList input)
        {
            if (input == null) return false;
            if (this.WarningCode != input.WarningCode || (this.WarningCode != null && !this.WarningCode.Equals(input.WarningCode))) return false;
            if (this.WarningMsg != input.WarningMsg || (this.WarningMsg != null && !this.WarningMsg.Equals(input.WarningMsg))) return false;

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
                if (this.WarningCode != null) hashCode = hashCode * 59 + this.WarningCode.GetHashCode();
                if (this.WarningMsg != null) hashCode = hashCode * 59 + this.WarningMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
