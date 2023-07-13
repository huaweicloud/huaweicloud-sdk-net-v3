using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTranscodeTemplate 
    {

        /// <summary>
        /// 模板组名称&lt;br/&gt; 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否设置成默认转码模板&lt;br/&gt; 
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 是否开启加密
        /// </summary>
        [JsonProperty("is_auto_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoEncrypt { get; set; }

        /// <summary>
        /// 画质配置信息列表&lt;br/&gt; 
        /// </summary>
        [JsonProperty("quality_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualityInfoList> QualityInfoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public CommonInfo Common { get; set; }

        /// <summary>
        /// 绑定的水印模板组ID数组&lt;br/&gt; 
        /// </summary>
        [JsonProperty("watermark_template_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WatermarkTemplateIds { get; set; }

        /// <summary>
        /// 模板介绍&lt;br/&gt; 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTranscodeTemplate {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  isAutoEncrypt: ").Append(IsAutoEncrypt).Append("\n");
            sb.Append("  qualityInfoList: ").Append(QualityInfoList).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("  watermarkTemplateIds: ").Append(WatermarkTemplateIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTranscodeTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTranscodeTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
                ) && 
                (
                    this.IsAutoEncrypt == input.IsAutoEncrypt ||
                    (this.IsAutoEncrypt != null &&
                    this.IsAutoEncrypt.Equals(input.IsAutoEncrypt))
                ) && 
                (
                    this.QualityInfoList == input.QualityInfoList ||
                    this.QualityInfoList != null &&
                    input.QualityInfoList != null &&
                    this.QualityInfoList.SequenceEqual(input.QualityInfoList)
                ) && 
                (
                    this.Common == input.Common ||
                    (this.Common != null &&
                    this.Common.Equals(input.Common))
                ) && 
                (
                    this.WatermarkTemplateIds == input.WatermarkTemplateIds ||
                    this.WatermarkTemplateIds != null &&
                    input.WatermarkTemplateIds != null &&
                    this.WatermarkTemplateIds.SequenceEqual(input.WatermarkTemplateIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.IsAutoEncrypt != null)
                    hashCode = hashCode * 59 + this.IsAutoEncrypt.GetHashCode();
                if (this.QualityInfoList != null)
                    hashCode = hashCode * 59 + this.QualityInfoList.GetHashCode();
                if (this.Common != null)
                    hashCode = hashCode * 59 + this.Common.GetHashCode();
                if (this.WatermarkTemplateIds != null)
                    hashCode = hashCode * 59 + this.WatermarkTemplateIds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
