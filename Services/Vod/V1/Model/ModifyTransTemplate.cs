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
    public class ModifyTransTemplate 
    {

        /// <summary>
        /// 模板组名称&lt;br/&gt; 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 模板组名称&lt;br/&gt; 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否是默认转码模板&lt;br/&gt; 
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 是否开启加密
        /// </summary>
        [JsonProperty("is_auto_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoEncrypt { get; set; }

        /// <summary>
        /// 自定义索引后缀列表，支持最大设置10个索引后缀。 如果填写索引后缀，则必须指定流名stream_name。 
        /// </summary>
        [JsonProperty("additional_manifests", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdditionalManifest> AdditionalManifests { get; set; }

        /// <summary>
        /// 画质配置信息列表&lt;br/&gt; 
        /// </summary>
        [JsonProperty("quality_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualityInfoList> QualityInfoList { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public CommonInfo Common { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTransTemplate {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  isAutoEncrypt: ").Append(IsAutoEncrypt).Append("\n");
            sb.Append("  additionalManifests: ").Append(AdditionalManifests).Append("\n");
            sb.Append("  qualityInfoList: ").Append(QualityInfoList).Append("\n");
            sb.Append("  watermarkTemplateIds: ").Append(WatermarkTemplateIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyTransTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTransTemplate input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.IsAutoEncrypt != input.IsAutoEncrypt || (this.IsAutoEncrypt != null && !this.IsAutoEncrypt.Equals(input.IsAutoEncrypt))) return false;
            if (this.AdditionalManifests != input.AdditionalManifests || (this.AdditionalManifests != null && input.AdditionalManifests != null && !this.AdditionalManifests.SequenceEqual(input.AdditionalManifests))) return false;
            if (this.QualityInfoList != input.QualityInfoList || (this.QualityInfoList != null && input.QualityInfoList != null && !this.QualityInfoList.SequenceEqual(input.QualityInfoList))) return false;
            if (this.WatermarkTemplateIds != input.WatermarkTemplateIds || (this.WatermarkTemplateIds != null && input.WatermarkTemplateIds != null && !this.WatermarkTemplateIds.SequenceEqual(input.WatermarkTemplateIds))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Common != input.Common || (this.Common != null && !this.Common.Equals(input.Common))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.IsAutoEncrypt != null) hashCode = hashCode * 59 + this.IsAutoEncrypt.GetHashCode();
                if (this.AdditionalManifests != null) hashCode = hashCode * 59 + this.AdditionalManifests.GetHashCode();
                if (this.QualityInfoList != null) hashCode = hashCode * 59 + this.QualityInfoList.GetHashCode();
                if (this.WatermarkTemplateIds != null) hashCode = hashCode * 59 + this.WatermarkTemplateIds.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Common != null) hashCode = hashCode * 59 + this.Common.GetHashCode();
                return hashCode;
            }
        }
    }
}
