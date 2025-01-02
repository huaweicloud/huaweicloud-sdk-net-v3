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
    /// 库回放请求体
    /// </summary>
    public class LogReplayDatabaseReq 
    {

        /// <summary>
        /// 需要恢复的库名列表
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreInfo> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogReplayDatabaseReq {\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogReplayDatabaseReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogReplayDatabaseReq input)
        {
            if (input == null) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;

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
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
