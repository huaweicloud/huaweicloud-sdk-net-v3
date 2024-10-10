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
    public class FlowPps 
    {

        /// <summary>
        /// 数据时间
        /// </summary>
        [JsonProperty("utime", NullValueHandling = NullValueHandling.Ignore)]
        public long? Utime { get; set; }

        /// <summary>
        /// 攻击包速率
        /// </summary>
        [JsonProperty("attack_pps", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackPps { get; set; }

        /// <summary>
        /// 正常包速率
        /// </summary>
        [JsonProperty("normal_pps", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalPps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowPps {\n");
            sb.Append("  utime: ").Append(Utime).Append("\n");
            sb.Append("  attackPps: ").Append(AttackPps).Append("\n");
            sb.Append("  normalPps: ").Append(NormalPps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowPps);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowPps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Utime == input.Utime ||
                    (this.Utime != null &&
                    this.Utime.Equals(input.Utime))
                ) && 
                (
                    this.AttackPps == input.AttackPps ||
                    (this.AttackPps != null &&
                    this.AttackPps.Equals(input.AttackPps))
                ) && 
                (
                    this.NormalPps == input.NormalPps ||
                    (this.NormalPps != null &&
                    this.NormalPps.Equals(input.NormalPps))
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
                if (this.Utime != null)
                    hashCode = hashCode * 59 + this.Utime.GetHashCode();
                if (this.AttackPps != null)
                    hashCode = hashCode * 59 + this.AttackPps.GetHashCode();
                if (this.NormalPps != null)
                    hashCode = hashCode * 59 + this.NormalPps.GetHashCode();
                return hashCode;
            }
        }
    }
}
