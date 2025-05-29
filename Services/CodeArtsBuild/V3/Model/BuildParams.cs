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
    /// 构建参数约束列表
    /// </summary>
    public class BuildParams 
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
        /// 简要构建信息列表
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public List<Params> Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildParams {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BuildParams input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Params != input.Params || (this.Params != null && input.Params != null && !this.Params.SequenceEqual(input.Params))) return false;

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
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
