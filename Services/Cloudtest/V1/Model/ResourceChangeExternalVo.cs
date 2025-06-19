using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 历史记录字段变更列表
    /// </summary>
    public class ResourceChangeExternalVo 
    {

        /// <summary>
        /// 变更字段
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 测试用例自定义字段类型
        /// </summary>
        [JsonProperty("custom_field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomFieldType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("old_change_info", NullValueHandling = NullValueHandling.Ignore)]
        public ElementResourceChangeExternalVo OldChangeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("new_change_info", NullValueHandling = NullValueHandling.Ignore)]
        public ElementResourceChangeExternalVo NewChangeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceChangeExternalVo {\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  customFieldType: ").Append(CustomFieldType).Append("\n");
            sb.Append("  oldChangeInfo: ").Append(OldChangeInfo).Append("\n");
            sb.Append("  newChangeInfo: ").Append(NewChangeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceChangeExternalVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceChangeExternalVo input)
        {
            if (input == null) return false;
            if (this.FieldName != input.FieldName || (this.FieldName != null && !this.FieldName.Equals(input.FieldName))) return false;
            if (this.CustomFieldType != input.CustomFieldType || (this.CustomFieldType != null && !this.CustomFieldType.Equals(input.CustomFieldType))) return false;
            if (this.OldChangeInfo != input.OldChangeInfo || (this.OldChangeInfo != null && !this.OldChangeInfo.Equals(input.OldChangeInfo))) return false;
            if (this.NewChangeInfo != input.NewChangeInfo || (this.NewChangeInfo != null && !this.NewChangeInfo.Equals(input.NewChangeInfo))) return false;

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
                if (this.FieldName != null) hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.CustomFieldType != null) hashCode = hashCode * 59 + this.CustomFieldType.GetHashCode();
                if (this.OldChangeInfo != null) hashCode = hashCode * 59 + this.OldChangeInfo.GetHashCode();
                if (this.NewChangeInfo != null) hashCode = hashCode * 59 + this.NewChangeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
