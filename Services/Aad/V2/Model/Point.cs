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
    public class Point 
    {

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public int? Time { get; set; }

        /// <summary>
        /// 请求总量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 攻击总量
        /// </summary>
        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public int? Attack { get; set; }

        /// <summary>
        /// web基础防护
        /// </summary>
        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public int? Basic { get; set; }

        /// <summary>
        /// 频率控制
        /// </summary>
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cc { get; set; }

        /// <summary>
        /// 精准防护
        /// </summary>
        [JsonProperty("custom_custom", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomCustom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Point {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  attack: ").Append(Attack).Append("\n");
            sb.Append("  basic: ").Append(Basic).Append("\n");
            sb.Append("  cc: ").Append(Cc).Append("\n");
            sb.Append("  customCustom: ").Append(CustomCustom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Point);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Point input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Attack != input.Attack || (this.Attack != null && !this.Attack.Equals(input.Attack))) return false;
            if (this.Basic != input.Basic || (this.Basic != null && !this.Basic.Equals(input.Basic))) return false;
            if (this.Cc != input.Cc || (this.Cc != null && !this.Cc.Equals(input.Cc))) return false;
            if (this.CustomCustom != input.CustomCustom || (this.CustomCustom != null && !this.CustomCustom.Equals(input.CustomCustom))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Attack != null) hashCode = hashCode * 59 + this.Attack.GetHashCode();
                if (this.Basic != null) hashCode = hashCode * 59 + this.Basic.GetHashCode();
                if (this.Cc != null) hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.CustomCustom != null) hashCode = hashCode * 59 + this.CustomCustom.GetHashCode();
                return hashCode;
            }
        }
    }
}
