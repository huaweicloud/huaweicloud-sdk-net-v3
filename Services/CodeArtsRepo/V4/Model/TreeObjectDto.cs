using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TreeObjectDto 
    {

        /// <summary>
        /// 文件唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 模式结构
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 子模块链接
        /// </summary>
        [JsonProperty("submodule_link", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmoduleLink { get; set; }

        /// <summary>
        /// 子模块分支
        /// </summary>
        [JsonProperty("submodule_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmoduleBranch { get; set; }

        /// <summary>
        /// md5值
        /// </summary>
        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TreeObjectDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  submoduleLink: ").Append(SubmoduleLink).Append("\n");
            sb.Append("  submoduleBranch: ").Append(SubmoduleBranch).Append("\n");
            sb.Append("  md5: ").Append(Md5).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TreeObjectDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TreeObjectDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.SubmoduleLink != input.SubmoduleLink || (this.SubmoduleLink != null && !this.SubmoduleLink.Equals(input.SubmoduleLink))) return false;
            if (this.SubmoduleBranch != input.SubmoduleBranch || (this.SubmoduleBranch != null && !this.SubmoduleBranch.Equals(input.SubmoduleBranch))) return false;
            if (this.Md5 != input.Md5 || (this.Md5 != null && !this.Md5.Equals(input.Md5))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.SubmoduleLink != null) hashCode = hashCode * 59 + this.SubmoduleLink.GetHashCode();
                if (this.SubmoduleBranch != null) hashCode = hashCode * 59 + this.SubmoduleBranch.GetHashCode();
                if (this.Md5 != null) hashCode = hashCode * 59 + this.Md5.GetHashCode();
                return hashCode;
            }
        }
    }
}
