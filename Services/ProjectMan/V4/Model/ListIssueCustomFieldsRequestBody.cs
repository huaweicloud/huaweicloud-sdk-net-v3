using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 查询Scrum工作项的自定义字段，custom_fields和names的相关自定义字段都返回
    /// </summary>
    public class ListIssueCustomFieldsRequestBody 
    {

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomFields { get; set; }

        /// <summary>
        /// 自定义字段页面显示的含义
        /// </summary>
        [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Names { get; set; }

        /// <summary>
        /// 查询结果是否包括未使用的自定义字段，默认仅查询使用中的自定义字段，设为true时查询项目中所有自定义字段
        /// </summary>
        [JsonProperty("included_not_in_use", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludedNotInUse { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIssueCustomFieldsRequestBody {\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  names: ").Append(Names).Append("\n");
            sb.Append("  includedNotInUse: ").Append(IncludedNotInUse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssueCustomFieldsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssueCustomFieldsRequestBody input)
        {
            if (input == null) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.Names != input.Names || (this.Names != null && input.Names != null && !this.Names.SequenceEqual(input.Names))) return false;
            if (this.IncludedNotInUse != input.IncludedNotInUse || (this.IncludedNotInUse != null && !this.IncludedNotInUse.Equals(input.IncludedNotInUse))) return false;

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
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Names != null) hashCode = hashCode * 59 + this.Names.GetHashCode();
                if (this.IncludedNotInUse != null) hashCode = hashCode * 59 + this.IncludedNotInUse.GetHashCode();
                return hashCode;
            }
        }
    }
}
