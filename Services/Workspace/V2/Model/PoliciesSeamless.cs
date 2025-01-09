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
    /// 通用音视频旁路。
    /// </summary>
    public class PoliciesSeamless 
    {

        /// <summary>
        /// 是否开启通用音视频开关。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("seamless_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SeamlessEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesSeamlessOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesSeamless {\n");
            sb.Append("  seamlessEnable: ").Append(SeamlessEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesSeamless);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesSeamless input)
        {
            if (input == null) return false;
            if (this.SeamlessEnable != input.SeamlessEnable || (this.SeamlessEnable != null && !this.SeamlessEnable.Equals(input.SeamlessEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.SeamlessEnable != null) hashCode = hashCode * 59 + this.SeamlessEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
