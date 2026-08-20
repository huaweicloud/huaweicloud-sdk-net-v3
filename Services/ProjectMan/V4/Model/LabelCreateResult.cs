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
    /// 工作项标签对象
    /// </summary>
    public class LabelCreateResult 
    {

        /// <summary>
        /// 标签ID，可通过查询标签列表接口获取，响应消息体中的id字段的值就是标签ID。 18~19个字符的数字字符串。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 标签所属工作项类型编码。
        /// </summary>
        [JsonProperty("category_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CategoryTypes { get; set; }

        /// <summary>
        /// 标签颜色RGB。 0~16个字符。
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 标签标题。 2~256个字符。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelCreateResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  categoryTypes: ").Append(CategoryTypes).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LabelCreateResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LabelCreateResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CategoryTypes != input.CategoryTypes || (this.CategoryTypes != null && input.CategoryTypes != null && !this.CategoryTypes.SequenceEqual(input.CategoryTypes))) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;

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
                if (this.CategoryTypes != null) hashCode = hashCode * 59 + this.CategoryTypes.GetHashCode();
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }
}
