using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 轻量级锁耗时信息
    /// </summary>
    public class LwlockTime 
    {

        /// <summary>
        /// **参数解释**: 总耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("all_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lwlock_time_details", NullValueHandling = NullValueHandling.Ignore)]
        public EventTimeInfo LwlockTimeDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LwlockTime {\n");
            sb.Append("  allTime: ").Append(AllTime).Append("\n");
            sb.Append("  lwlockTimeDetails: ").Append(LwlockTimeDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LwlockTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LwlockTime input)
        {
            if (input == null) return false;
            if (this.AllTime != input.AllTime || (this.AllTime != null && !this.AllTime.Equals(input.AllTime))) return false;
            if (this.LwlockTimeDetails != input.LwlockTimeDetails || (this.LwlockTimeDetails != null && !this.LwlockTimeDetails.Equals(input.LwlockTimeDetails))) return false;

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
                if (this.AllTime != null) hashCode = hashCode * 59 + this.AllTime.GetHashCode();
                if (this.LwlockTimeDetails != null) hashCode = hashCode * 59 + this.LwlockTimeDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
