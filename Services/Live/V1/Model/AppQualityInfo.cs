using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AppQualityInfo 
    {

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 视频质量信息
        /// </summary>
        [JsonProperty("quality_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualityInfo> QualityInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppQualityInfo {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  qualityInfo: ").Append(QualityInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppQualityInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppQualityInfo input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.QualityInfo != input.QualityInfo || (this.QualityInfo != null && input.QualityInfo != null && !this.QualityInfo.SequenceEqual(input.QualityInfo))) return false;

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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.QualityInfo != null) hashCode = hashCode * 59 + this.QualityInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
