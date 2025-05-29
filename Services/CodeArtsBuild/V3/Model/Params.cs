using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 构建参数
    /// </summary>
    public class Params 
    {

        /// <summary>
        /// 参数名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// 简要构建信息列表
        /// </summary>
        [JsonProperty("constraints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Constraints> Constraints { get; set; }

        /// <summary>
        /// 删除
        /// </summary>
        [JsonProperty("deletion", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletion { get; set; }

        /// <summary>
        /// 默认
        /// </summary>
        [JsonProperty("defaults", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Params {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  constraints: ").Append(Constraints).Append("\n");
            sb.Append("  deletion: ").Append(Deletion).Append("\n");
            sb.Append("  defaults: ").Append(Defaults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Params);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Params input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.Constraints != input.Constraints || (this.Constraints != null && input.Constraints != null && !this.Constraints.SequenceEqual(input.Constraints))) return false;
            if (this.Deletion != input.Deletion || (this.Deletion != null && !this.Deletion.Equals(input.Deletion))) return false;
            if (this.Defaults != input.Defaults || (this.Defaults != null && !this.Defaults.Equals(input.Defaults))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Constraints != null) hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                if (this.Deletion != null) hashCode = hashCode * 59 + this.Deletion.GetHashCode();
                if (this.Defaults != null) hashCode = hashCode * 59 + this.Defaults.GetHashCode();
                return hashCode;
            }
        }
    }
}
