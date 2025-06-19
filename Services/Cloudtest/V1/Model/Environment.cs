using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Environment 
    {

        /// <summary>
        /// 环境分组id
        /// </summary>
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// 环境分组名
        /// </summary>
        [JsonProperty("environment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// 环境分组描述
        /// </summary>
        [JsonProperty("environment_description", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentDescription { get; set; }

        /// <summary>
        /// 是否是默认环境
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Environment {\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  environmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  environmentDescription: ").Append(EnvironmentDescription).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Environment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Environment input)
        {
            if (input == null) return false;
            if (this.EnvironmentId != input.EnvironmentId || (this.EnvironmentId != null && !this.EnvironmentId.Equals(input.EnvironmentId))) return false;
            if (this.EnvironmentName != input.EnvironmentName || (this.EnvironmentName != null && !this.EnvironmentName.Equals(input.EnvironmentName))) return false;
            if (this.EnvironmentDescription != input.EnvironmentDescription || (this.EnvironmentDescription != null && !this.EnvironmentDescription.Equals(input.EnvironmentDescription))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;

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
                if (this.EnvironmentId != null) hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.EnvironmentName != null) hashCode = hashCode * 59 + this.EnvironmentName.GetHashCode();
                if (this.EnvironmentDescription != null) hashCode = hashCode * 59 + this.EnvironmentDescription.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
