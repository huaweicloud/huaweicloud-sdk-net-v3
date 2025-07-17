using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckCallNumberInConfResponse : SdkResponse
    {

        /// <summary>
        /// 是否在会议中
        /// </summary>
        [JsonProperty("in_conf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InConf { get; set; }

        /// <summary>
        /// 会议id
        /// </summary>
        [JsonProperty("conf_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckCallNumberInConfResponse {\n");
            sb.Append("  inConf: ").Append(InConf).Append("\n");
            sb.Append("  confId: ").Append(ConfId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckCallNumberInConfResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckCallNumberInConfResponse input)
        {
            if (input == null) return false;
            if (this.InConf != input.InConf || (this.InConf != null && !this.InConf.Equals(input.InConf))) return false;
            if (this.ConfId != input.ConfId || (this.ConfId != null && !this.ConfId.Equals(input.ConfId))) return false;

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
                if (this.InConf != null) hashCode = hashCode * 59 + this.InConf.GetHashCode();
                if (this.ConfId != null) hashCode = hashCode * 59 + this.ConfId.GetHashCode();
                return hashCode;
            }
        }
    }
}
