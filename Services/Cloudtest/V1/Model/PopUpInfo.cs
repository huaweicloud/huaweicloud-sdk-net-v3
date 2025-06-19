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
    public class PopUpInfo 
    {

        /// <summary>
        /// 是否弹窗
        /// </summary>
        [JsonProperty("popup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Popup { get; set; }

        /// <summary>
        /// 包周期计费时长上限
        /// </summary>
        [JsonProperty("time_limit", NullValueHandling = NullValueHandling.Ignore)]
        public Object TimeLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PopUpInfo {\n");
            sb.Append("  popup: ").Append(Popup).Append("\n");
            sb.Append("  timeLimit: ").Append(TimeLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PopUpInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PopUpInfo input)
        {
            if (input == null) return false;
            if (this.Popup != input.Popup || (this.Popup != null && !this.Popup.Equals(input.Popup))) return false;
            if (this.TimeLimit != input.TimeLimit || (this.TimeLimit != null && !this.TimeLimit.Equals(input.TimeLimit))) return false;

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
                if (this.Popup != null) hashCode = hashCode * 59 + this.Popup.GetHashCode();
                if (this.TimeLimit != null) hashCode = hashCode * 59 + this.TimeLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
