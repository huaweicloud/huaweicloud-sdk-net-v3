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
    /// 在线会议信息。
    /// </summary>
    public class RealTimeConfInfo 
    {

        /// <summary>
        /// 主持人与会者标识。
        /// </summary>
        [JsonProperty("chairID", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairID { get; set; }

        /// <summary>
        /// 联席主持人会场id。
        /// </summary>
        [JsonProperty("coHosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CoHosts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeConfInfo {\n");
            sb.Append("  chairID: ").Append(ChairID).Append("\n");
            sb.Append("  coHosts: ").Append(CoHosts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealTimeConfInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealTimeConfInfo input)
        {
            if (input == null) return false;
            if (this.ChairID != input.ChairID || (this.ChairID != null && !this.ChairID.Equals(input.ChairID))) return false;
            if (this.CoHosts != input.CoHosts || (this.CoHosts != null && input.CoHosts != null && !this.CoHosts.SequenceEqual(input.CoHosts))) return false;

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
                if (this.ChairID != null) hashCode = hashCode * 59 + this.ChairID.GetHashCode();
                if (this.CoHosts != null) hashCode = hashCode * 59 + this.CoHosts.GetHashCode();
                return hashCode;
            }
        }
    }
}
