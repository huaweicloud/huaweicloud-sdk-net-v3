using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 华为云CBS应用配置
    /// </summary>
    public class HuaweiEiCbs 
    {

        /// <summary>
        /// CBS应用ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// CBS所在区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public int? Region { get; set; }

        /// <summary>
        /// CBS所在区域的projectId
        /// </summary>
        [JsonProperty("cbs_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CbsProjectId { get; set; }

        /// <summary>
        /// SIS所在区域
        /// </summary>
        [JsonProperty("sis_region", NullValueHandling = NullValueHandling.Ignore)]
        public int? SisRegion { get; set; }

        /// <summary>
        /// SIS所在区域的projectId
        /// </summary>
        [JsonProperty("sis_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SisProjectId { get; set; }

        /// <summary>
        /// 是否开启热词
        /// </summary>
        [JsonProperty("enable_hot_words", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHotWords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HuaweiEiCbs {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  cbsProjectId: ").Append(CbsProjectId).Append("\n");
            sb.Append("  sisRegion: ").Append(SisRegion).Append("\n");
            sb.Append("  sisProjectId: ").Append(SisProjectId).Append("\n");
            sb.Append("  enableHotWords: ").Append(EnableHotWords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HuaweiEiCbs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HuaweiEiCbs input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CbsProjectId != input.CbsProjectId || (this.CbsProjectId != null && !this.CbsProjectId.Equals(input.CbsProjectId))) return false;
            if (this.SisRegion != input.SisRegion || (this.SisRegion != null && !this.SisRegion.Equals(input.SisRegion))) return false;
            if (this.SisProjectId != input.SisProjectId || (this.SisProjectId != null && !this.SisProjectId.Equals(input.SisProjectId))) return false;
            if (this.EnableHotWords != input.EnableHotWords || (this.EnableHotWords != null && !this.EnableHotWords.Equals(input.EnableHotWords))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CbsProjectId != null) hashCode = hashCode * 59 + this.CbsProjectId.GetHashCode();
                if (this.SisRegion != null) hashCode = hashCode * 59 + this.SisRegion.GetHashCode();
                if (this.SisProjectId != null) hashCode = hashCode * 59 + this.SisProjectId.GetHashCode();
                if (this.EnableHotWords != null) hashCode = hashCode * 59 + this.EnableHotWords.GetHashCode();
                return hashCode;
            }
        }
    }
}
