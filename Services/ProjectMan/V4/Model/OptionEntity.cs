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
    /// 字段选项
    /// </summary>
    public class OptionEntity 
    {

        /// <summary>
        /// 选项id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 选项code值
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 选项显示名称
        /// </summary>
        [JsonProperty("display_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// 选项唯一标识
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 选项层级。用于区分层级字段的层级
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 选项顺序
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// 父选项id
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  displayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OptionEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OptionEntity input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.DisplayValue != input.DisplayValue || (this.DisplayValue != null && !this.DisplayValue.Equals(input.DisplayValue))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DisplayValue != null) hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
