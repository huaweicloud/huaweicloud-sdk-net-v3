using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IntranetConnectionDeleteRequest 
    {

        /// <summary>
        /// 内网接入的id列表
        /// </summary>
        [JsonProperty("intranet_connection_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IntranetConnectionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntranetConnectionDeleteRequest {\n");
            sb.Append("  intranetConnectionIds: ").Append(IntranetConnectionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntranetConnectionDeleteRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IntranetConnectionDeleteRequest input)
        {
            if (input == null) return false;
            if (this.IntranetConnectionIds != input.IntranetConnectionIds || (this.IntranetConnectionIds != null && input.IntranetConnectionIds != null && !this.IntranetConnectionIds.SequenceEqual(input.IntranetConnectionIds))) return false;

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
                if (this.IntranetConnectionIds != null) hashCode = hashCode * 59 + this.IntranetConnectionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
