using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// 获取租户的习题库过滤字段
    /// </summary>
    public class PackageFilter 
    {

        /// <summary>
        /// 需查询的习题库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 标签名称列表
        /// </summary>
        [JsonProperty("tag_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageFilter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tagNames: ").Append(TagNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageFilter input)
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
                    this.TagNames == input.TagNames ||
                    this.TagNames != null &&
                    input.TagNames != null &&
                    this.TagNames.SequenceEqual(input.TagNames)
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
                if (this.TagNames != null)
                    hashCode = hashCode * 59 + this.TagNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
