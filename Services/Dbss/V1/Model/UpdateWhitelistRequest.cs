using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateWhitelistRequest 
    {

        /// <summary>
        /// 数据库ID列表
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DbIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 是否启用  - true：启用  - false：禁用
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWhitelistRequest {\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWhitelistRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWhitelistRequest input)
        {
            if (input == null) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && input.DbIds != null && !this.DbIds.SequenceEqual(input.DbIds))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
