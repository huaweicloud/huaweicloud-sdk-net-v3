using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 包含自定义应用业务扩展信息的对象
    /// </summary>
    public class AppExtendedInfo 
    {

        /// <summary>
        /// 扩展信息的键值对映射
        /// </summary>
        [JsonProperty("extended_info", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtendedInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppExtendedInfo {\n");
            sb.Append("  extendedInfo: ").Append(ExtendedInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppExtendedInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppExtendedInfo input)
        {
            if (input == null) return false;
            if (this.ExtendedInfo != input.ExtendedInfo || (this.ExtendedInfo != null && input.ExtendedInfo != null && !this.ExtendedInfo.SequenceEqual(input.ExtendedInfo))) return false;

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
                if (this.ExtendedInfo != null) hashCode = hashCode * 59 + this.ExtendedInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
