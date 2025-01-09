using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面使用时间。
    /// </summary>
    public class DesktopUsedInfo 
    {

        /// <summary>
        /// 日期，格式：yyyy-MM-dd（UTC时间）。
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 总共在线时间单位:小时数（h）,精确到两位小数，如：1.32。
        /// </summary>
        [JsonProperty("use_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UseTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopUsedInfo {\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  useTime: ").Append(UseTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopUsedInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopUsedInfo input)
        {
            if (input == null) return false;
            if (this.Date != input.Date || (this.Date != null && !this.Date.Equals(input.Date))) return false;
            if (this.UseTime != input.UseTime || (this.UseTime != null && !this.UseTime.Equals(input.UseTime))) return false;

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
                if (this.Date != null) hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.UseTime != null) hashCode = hashCode * 59 + this.UseTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
