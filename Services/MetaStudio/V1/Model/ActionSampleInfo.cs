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
    /// 原子动作样例详情。
    /// </summary>
    public class ActionSampleInfo 
    {

        /// <summary>
        /// 原子动作中文名称。
        /// </summary>
        [JsonProperty("action_name_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionNameZh { get; set; }

        /// <summary>
        /// 原子动作英文名称。
        /// </summary>
        [JsonProperty("action_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionNameEn { get; set; }

        /// <summary>
        /// 动作Tag。
        /// </summary>
        [JsonProperty("action_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionTag { get; set; }

        /// <summary>
        /// 动作分类名称。
        /// </summary>
        [JsonProperty("catalog", NullValueHandling = NullValueHandling.Ignore)]
        public string Catalog { get; set; }

        /// <summary>
        /// 推荐等级。
        /// </summary>
        [JsonProperty("recommended_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecommendedValue { get; set; }

        /// <summary>
        /// 是否选择此动作。
        /// </summary>
        [JsonProperty("is_selected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSelected { get; set; }

        /// <summary>
        /// 原子动作样例文件下载地址。24小时内有效。
        /// </summary>
        [JsonProperty("sample_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SampleDownloadUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionSampleInfo {\n");
            sb.Append("  actionNameZh: ").Append(ActionNameZh).Append("\n");
            sb.Append("  actionNameEn: ").Append(ActionNameEn).Append("\n");
            sb.Append("  actionTag: ").Append(ActionTag).Append("\n");
            sb.Append("  catalog: ").Append(Catalog).Append("\n");
            sb.Append("  recommendedValue: ").Append(RecommendedValue).Append("\n");
            sb.Append("  isSelected: ").Append(IsSelected).Append("\n");
            sb.Append("  sampleDownloadUrl: ").Append(SampleDownloadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionSampleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionSampleInfo input)
        {
            if (input == null) return false;
            if (this.ActionNameZh != input.ActionNameZh || (this.ActionNameZh != null && !this.ActionNameZh.Equals(input.ActionNameZh))) return false;
            if (this.ActionNameEn != input.ActionNameEn || (this.ActionNameEn != null && !this.ActionNameEn.Equals(input.ActionNameEn))) return false;
            if (this.ActionTag != input.ActionTag || (this.ActionTag != null && !this.ActionTag.Equals(input.ActionTag))) return false;
            if (this.Catalog != input.Catalog || (this.Catalog != null && !this.Catalog.Equals(input.Catalog))) return false;
            if (this.RecommendedValue != input.RecommendedValue || (this.RecommendedValue != null && !this.RecommendedValue.Equals(input.RecommendedValue))) return false;
            if (this.IsSelected != input.IsSelected || (this.IsSelected != null && !this.IsSelected.Equals(input.IsSelected))) return false;
            if (this.SampleDownloadUrl != input.SampleDownloadUrl || (this.SampleDownloadUrl != null && !this.SampleDownloadUrl.Equals(input.SampleDownloadUrl))) return false;

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
                if (this.ActionNameZh != null) hashCode = hashCode * 59 + this.ActionNameZh.GetHashCode();
                if (this.ActionNameEn != null) hashCode = hashCode * 59 + this.ActionNameEn.GetHashCode();
                if (this.ActionTag != null) hashCode = hashCode * 59 + this.ActionTag.GetHashCode();
                if (this.Catalog != null) hashCode = hashCode * 59 + this.Catalog.GetHashCode();
                if (this.RecommendedValue != null) hashCode = hashCode * 59 + this.RecommendedValue.GetHashCode();
                if (this.IsSelected != null) hashCode = hashCode * 59 + this.IsSelected.GetHashCode();
                if (this.SampleDownloadUrl != null) hashCode = hashCode * 59 + this.SampleDownloadUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
