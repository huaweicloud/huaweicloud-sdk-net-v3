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
    /// 模板列表
    /// </summary>
    public class TemplateList 
    {

        /// <summary>
        /// 模版支持的语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 是否收藏模板
        /// </summary>
        [JsonProperty("favourite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Favourite { get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 模板类别
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 模板命名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        /// <summary>
        /// 模板范围，自定义模板默认为：custom,官方模版为：official
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// 模板说明
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 模板是否公开
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        /// <summary>
        /// 构建工具类型，mono、npm、maven等
        /// </summary>
        [JsonProperty("tool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public QueryTemplate Template { get; set; }

        /// <summary>
        /// 构建执行参数列表
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Parameter> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateList {\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  favourite: ").Append(Favourite).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  toolType: ").Append(ToolType).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateList input)
        {
            if (input == null) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Favourite != input.Favourite || (this.Favourite != null && !this.Favourite.Equals(input.Favourite))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.Public != input.Public || (this.Public != null && !this.Public.Equals(input.Public))) return false;
            if (this.ToolType != input.ToolType || (this.ToolType != null && !this.ToolType.Equals(input.ToolType))) return false;
            if (this.Template != input.Template || (this.Template != null && !this.Template.Equals(input.Template))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Favourite != null) hashCode = hashCode * 59 + this.Favourite.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.Public != null) hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.ToolType != null) hashCode = hashCode * 59 + this.ToolType.GetHashCode();
                if (this.Template != null) hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
