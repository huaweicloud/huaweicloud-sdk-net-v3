using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RealtimeScaleDimensionValue 
    {

        /// <summary>
        /// 维度值，如查询维度为region，则此处取值可能为GD 
        /// </summary>
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string Dimension { get; set; }

        /// <summary>
        /// 在线观众数
        /// </summary>
        [JsonProperty("online_users", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnlineUsers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeScaleDimensionValue {\n");
            sb.Append("  dimension: ").Append(Dimension).Append("\n");
            sb.Append("  onlineUsers: ").Append(OnlineUsers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealtimeScaleDimensionValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealtimeScaleDimensionValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
                ) && 
                (
                    this.OnlineUsers == input.OnlineUsers ||
                    (this.OnlineUsers != null &&
                    this.OnlineUsers.Equals(input.OnlineUsers))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Dimension != null)
                    hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.OnlineUsers != null)
                    hashCode = hashCode * 59 + this.OnlineUsers.GetHashCode();
                return hashCode;
            }
        }
    }
}
