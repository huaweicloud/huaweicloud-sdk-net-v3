using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 参数模板信息
    /// </summary>
    public class UpdateConfigurationRspConfiguration 
    {

        /// <summary>
        /// 参数模板ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数模板名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 请求参数“values”中被忽略掉，没有生效的参数名称列表。 当参数不存在时，参数修改不会下发，并通过此参数返回所有被忽略的参数名称。
        /// </summary>
        [JsonProperty("ignored_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IgnoredParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateConfigurationRspConfiguration {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ignoredParams: ").Append(IgnoredParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateConfigurationRspConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateConfigurationRspConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IgnoredParams == input.IgnoredParams ||
                    this.IgnoredParams != null &&
                    input.IgnoredParams != null &&
                    this.IgnoredParams.SequenceEqual(input.IgnoredParams)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IgnoredParams != null)
                    hashCode = hashCode * 59 + this.IgnoredParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
