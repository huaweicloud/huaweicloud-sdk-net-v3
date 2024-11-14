using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDbCacheMappingRequestBody 
    {

        /// <summary>
        /// 内存加速源实例ID。当前支持云数据库RDS for MySQL和GaussDB(for MySQL)实例。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 内存加速目标实例ID。当前仅支持GeminiDB Redis主备类型实例。
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDbCacheMappingRequestBody {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDbCacheMappingRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDbCacheMappingRequestBody input)
        {
            if (input == null) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.TargetInstanceId != input.TargetInstanceId || (this.TargetInstanceId != null && !this.TargetInstanceId.Equals(input.TargetInstanceId))) return false;

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
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.TargetInstanceId != null) hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
