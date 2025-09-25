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
    /// 全量SQL开关记录
    /// </summary>
    public class SqlTypeRangeConfigResult 
    {

        /// <summary>
        /// **参数解释**: 是否开启全量SQL。 **取值范围**: - true：已开启。 - false：已关闭。
        /// </summary>
        [JsonProperty("is_open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// **参数解释**: 开关状态持续的开始时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlTypeRangeConfigResult {\n");
            sb.Append("  isOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlTypeRangeConfigResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlTypeRangeConfigResult input)
        {
            if (input == null) return false;
            if (this.IsOpen != input.IsOpen || (this.IsOpen != null && !this.IsOpen.Equals(input.IsOpen))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;

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
                if (this.IsOpen != null) hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
