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
    /// 申请联席主持人请求。
    /// </summary>
    public class RestSetCohostBody 
    {

        /// <summary>
        /// - 0：撤销联席主持人 - 1：设置联席主持人
        /// </summary>
        [JsonProperty("isCohost", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsCohost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetCohostBody {\n");
            sb.Append("  isCohost: ").Append(IsCohost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetCohostBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetCohostBody input)
        {
            if (input == null) return false;
            if (this.IsCohost != input.IsCohost || (this.IsCohost != null && !this.IsCohost.Equals(input.IsCohost))) return false;

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
                if (this.IsCohost != null) hashCode = hashCode * 59 + this.IsCohost.GetHashCode();
                return hashCode;
            }
        }
    }
}
