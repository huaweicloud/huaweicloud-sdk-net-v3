using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateSecretRequest 
    {

        /// <summary>
        /// 项目名称，缺省值默认为区域名称，例如：cn-north-1。 
        /// </summary>
        [SDKProperty("projectname", IsQuery = true)]
        [JsonProperty("projectname", NullValueHandling = NullValueHandling.Ignore)]
        public string Projectname { get; set; }

        /// <summary>
        /// 自定义临时凭证有效期，单位秒，取值范围15min-24h
        /// </summary>
        [SDKProperty("duration_seconds", IsQuery = true)]
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecretRequest {\n");
            sb.Append("  projectname: ").Append(Projectname).Append("\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecretRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretRequest input)
        {
            if (input == null) return false;
            if (this.Projectname != input.Projectname || (this.Projectname != null && !this.Projectname.Equals(input.Projectname))) return false;
            if (this.DurationSeconds != input.DurationSeconds || (this.DurationSeconds != null && !this.DurationSeconds.Equals(input.DurationSeconds))) return false;

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
                if (this.Projectname != null) hashCode = hashCode * 59 + this.Projectname.GetHashCode();
                if (this.DurationSeconds != null) hashCode = hashCode * 59 + this.DurationSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
