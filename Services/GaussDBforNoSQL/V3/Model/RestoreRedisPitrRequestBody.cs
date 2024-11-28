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
    public class RestoreRedisPitrRequestBody 
    {

        /// <summary>
        /// 恢复的指定时间点, 格式为yyyy-mm-ddThh:mm:ssZ字符串格式，T指某个时间的开始，Z指时区偏移量。  获取方法请参见 查询Redis可恢复时间点 中响应“restore_time”字段下参数的值。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreRedisPitrRequestBody {\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreRedisPitrRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreRedisPitrRequestBody input)
        {
            if (input == null) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;

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
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
