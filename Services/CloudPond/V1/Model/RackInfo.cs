using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 机柜信息
    /// </summary>
    public class RackInfo 
    {

        /// <summary>
        /// 机柜功率，单位：w
        /// </summary>
        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public int? Power { get; set; }

        /// <summary>
        /// 机柜尺寸，如100\\*200\\*200，单位：cm
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// 是否有机柜锁。
        /// </summary>
        [JsonProperty("has_lock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasLock { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RackInfo {\n");
            sb.Append("  power: ").Append(Power).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  hasLock: ").Append(HasLock).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RackInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RackInfo input)
        {
            if (input == null) return false;
            if (this.Power != input.Power || (this.Power != null && !this.Power.Equals(input.Power))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.HasLock != input.HasLock || (this.HasLock != null && !this.HasLock.Equals(input.HasLock))) return false;

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
                if (this.Power != null) hashCode = hashCode * 59 + this.Power.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.HasLock != null) hashCode = hashCode * 59 + this.HasLock.GetHashCode();
                return hashCode;
            }
        }
    }
}
