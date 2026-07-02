using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 获取DDL日志下载链接请求体
    /// </summary>
    public class DownloadDdlLogsRequestBody 
    {

        /// <summary>
        /// **参数解释**：  DDL日志文件ID列表。  **约束限制**：  列表数量小于等于10。  **取值范围**：  不涉及。  **默认取值**：  不涉及。 
        /// </summary>
        [JsonProperty("log_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadDdlLogsRequestBody {\n");
            sb.Append("  logIds: ").Append(LogIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadDdlLogsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadDdlLogsRequestBody input)
        {
            if (input == null) return false;
            if (this.LogIds != input.LogIds || (this.LogIds != null && input.LogIds != null && !this.LogIds.SequenceEqual(input.LogIds))) return false;

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
                if (this.LogIds != null) hashCode = hashCode * 59 + this.LogIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
