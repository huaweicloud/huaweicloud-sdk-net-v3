using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlowBps 
    {

        /// <summary>
        /// 数据时间
        /// </summary>
        [JsonProperty("utime", NullValueHandling = NullValueHandling.Ignore)]
        public long? Utime { get; set; }

        /// <summary>
        /// 攻击流量
        /// </summary>
        [JsonProperty("attack_bps", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackBps { get; set; }

        /// <summary>
        /// 正常流量
        /// </summary>
        [JsonProperty("normal_bps", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalBps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowBps {\n");
            sb.Append("  utime: ").Append(Utime).Append("\n");
            sb.Append("  attackBps: ").Append(AttackBps).Append("\n");
            sb.Append("  normalBps: ").Append(NormalBps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowBps);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowBps input)
        {
            if (input == null) return false;
            if (this.Utime != input.Utime || (this.Utime != null && !this.Utime.Equals(input.Utime))) return false;
            if (this.AttackBps != input.AttackBps || (this.AttackBps != null && !this.AttackBps.Equals(input.AttackBps))) return false;
            if (this.NormalBps != input.NormalBps || (this.NormalBps != null && !this.NormalBps.Equals(input.NormalBps))) return false;

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
                if (this.Utime != null) hashCode = hashCode * 59 + this.Utime.GetHashCode();
                if (this.AttackBps != null) hashCode = hashCode * 59 + this.AttackBps.GetHashCode();
                if (this.NormalBps != null) hashCode = hashCode * 59 + this.NormalBps.GetHashCode();
                return hashCode;
            }
        }
    }
}
