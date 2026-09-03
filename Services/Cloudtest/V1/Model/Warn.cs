using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Warn 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("warn_code", NullValueHandling = NullValueHandling.Ignore)]
        public string WarnCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("warn_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string WarnMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Warn {\n");
            sb.Append("  warnCode: ").Append(WarnCode).Append("\n");
            sb.Append("  warnMsg: ").Append(WarnMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Warn);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Warn input)
        {
            if (input == null) return false;
            if (this.WarnCode != input.WarnCode || (this.WarnCode != null && !this.WarnCode.Equals(input.WarnCode))) return false;
            if (this.WarnMsg != input.WarnMsg || (this.WarnMsg != null && !this.WarnMsg.Equals(input.WarnMsg))) return false;

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
                if (this.WarnCode != null) hashCode = hashCode * 59 + this.WarnCode.GetHashCode();
                if (this.WarnMsg != null) hashCode = hashCode * 59 + this.WarnMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
