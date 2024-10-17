using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 采集数据库位点信息
    /// </summary>
    public class QueryDbPositionReq 
    {

        /// <summary>
        /// 重置位点时间, 使用UTC时间 示例：2023-09-19 15:00:00，UTC时间是2023-09-19T07:00:00Z
        /// </summary>
        [JsonProperty("reset_position_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ResetPositionTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDbPositionReq {\n");
            sb.Append("  resetPositionTime: ").Append(ResetPositionTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDbPositionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDbPositionReq input)
        {
            if (input == null) return false;
            if (this.ResetPositionTime != input.ResetPositionTime || (this.ResetPositionTime != null && !this.ResetPositionTime.Equals(input.ResetPositionTime))) return false;

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
                if (this.ResetPositionTime != null) hashCode = hashCode * 59 + this.ResetPositionTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
