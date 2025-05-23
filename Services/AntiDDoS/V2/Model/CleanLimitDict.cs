using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V2.Model
{
    /// <summary>
    /// 连接数限制列表
    /// </summary>
    public class CleanLimitDict 
    {

        /// <summary>
        /// 清洗时访问限制分段ID，取值范围：1：10M;2：30M;3：50M;4：70M;5：100M;6：150M;7：200M;8：250M;9：300M;10：500M;11：800M;88：1000M;99：默认防护。
        /// </summary>
        [JsonProperty("cleaning_access_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CleaningAccessPosId { get; set; }

        /// <summary>
        /// 单一源IP新建连接个数
        /// </summary>
        [JsonProperty("new_connection_limited", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewConnectionLimited { get; set; }

        /// <summary>
        /// 单一源IP连接数总个数
        /// </summary>
        [JsonProperty("total_connection_limited", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalConnectionLimited { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleanLimitDict {\n");
            sb.Append("  cleaningAccessPosId: ").Append(CleaningAccessPosId).Append("\n");
            sb.Append("  newConnectionLimited: ").Append(NewConnectionLimited).Append("\n");
            sb.Append("  totalConnectionLimited: ").Append(TotalConnectionLimited).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CleanLimitDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CleanLimitDict input)
        {
            if (input == null) return false;
            if (this.CleaningAccessPosId != input.CleaningAccessPosId || (this.CleaningAccessPosId != null && !this.CleaningAccessPosId.Equals(input.CleaningAccessPosId))) return false;
            if (this.NewConnectionLimited != input.NewConnectionLimited || (this.NewConnectionLimited != null && !this.NewConnectionLimited.Equals(input.NewConnectionLimited))) return false;
            if (this.TotalConnectionLimited != input.TotalConnectionLimited || (this.TotalConnectionLimited != null && !this.TotalConnectionLimited.Equals(input.TotalConnectionLimited))) return false;

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
                if (this.CleaningAccessPosId != null) hashCode = hashCode * 59 + this.CleaningAccessPosId.GetHashCode();
                if (this.NewConnectionLimited != null) hashCode = hashCode * 59 + this.NewConnectionLimited.GetHashCode();
                if (this.TotalConnectionLimited != null) hashCode = hashCode * 59 + this.TotalConnectionLimited.GetHashCode();
                return hashCode;
            }
        }
    }
}
