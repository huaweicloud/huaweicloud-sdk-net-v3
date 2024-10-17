using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 创建别名请求体
    /// </summary>
    public class CreateVersionAliasRequestBody 
    {

        /// <summary>
        /// 别名名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 别名对应的版本名称。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 别名描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 百分比灰度配置信息
        /// </summary>
        [JsonProperty("additional_version_weights", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> AdditionalVersionWeights { get; set; }

        /// <summary>
        /// 指定规则灰度策略信息
        /// </summary>
        [JsonProperty("additional_version_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, VersionStrategy> AdditionalVersionStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVersionAliasRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  additionalVersionWeights: ").Append(AdditionalVersionWeights).Append("\n");
            sb.Append("  additionalVersionStrategy: ").Append(AdditionalVersionStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVersionAliasRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVersionAliasRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AdditionalVersionWeights != input.AdditionalVersionWeights || (this.AdditionalVersionWeights != null && input.AdditionalVersionWeights != null && !this.AdditionalVersionWeights.SequenceEqual(input.AdditionalVersionWeights))) return false;
            if (this.AdditionalVersionStrategy != input.AdditionalVersionStrategy || (this.AdditionalVersionStrategy != null && input.AdditionalVersionStrategy != null && !this.AdditionalVersionStrategy.SequenceEqual(input.AdditionalVersionStrategy))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdditionalVersionWeights != null) hashCode = hashCode * 59 + this.AdditionalVersionWeights.GetHashCode();
                if (this.AdditionalVersionStrategy != null) hashCode = hashCode * 59 + this.AdditionalVersionStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
