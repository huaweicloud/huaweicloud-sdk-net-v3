using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IdentityToken 
    {

        /// <summary>
        /// token的ID。与请求头中的X-Auth-Token填写其一即可，若都填写，优先校验X-Auth-Token。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// AK/SK和securitytoken的有效期，时间单位为秒。取值范围：15min ~ 24h ，默认为15min。
        /// </summary>
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityToken {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityToken);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdentityToken input)
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
                    this.DurationSeconds == input.DurationSeconds ||
                    (this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(input.DurationSeconds))
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
                if (this.DurationSeconds != null)
                    hashCode = hashCode * 59 + this.DurationSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
