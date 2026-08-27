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
    /// **参数解释**： 单个事务的进度信息。 
    /// </summary>
    public class TxnItem 
    {

        /// <summary>
        /// **参数解释**： 事务的唯一标识。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("trx_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrxId { get; set; }

        /// <summary>
        /// **参数解释**： 预计剩余完成时间（秒）。 **取值范围**： ＞0。 
        /// </summary>
        [JsonProperty("estimated_remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EstimatedRemainingTime { get; set; }

        /// <summary>
        /// **参数解释**： 用户会话线程ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("trx_mysql_thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrxMysqlThreadId { get; set; }

        /// <summary>
        /// **参数解释**： 额外信息，通常是正在执行的语句。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("trx_query", NullValueHandling = NullValueHandling.Ignore)]
        public string TrxQuery { get; set; }

        /// <summary>
        /// **参数解释**： 事务开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("trx_started", NullValueHandling = NullValueHandling.Ignore)]
        public string TrxStarted { get; set; }

        /// <summary>
        /// **参数解释**： 事务修改的行数。 **取值范围**： ≥0。 
        /// </summary>
        [JsonProperty("trx_rows_modified", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrxRowsModified { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxnItem {\n");
            sb.Append("  trxId: ").Append(TrxId).Append("\n");
            sb.Append("  estimatedRemainingTime: ").Append(EstimatedRemainingTime).Append("\n");
            sb.Append("  trxMysqlThreadId: ").Append(TrxMysqlThreadId).Append("\n");
            sb.Append("  trxQuery: ").Append(TrxQuery).Append("\n");
            sb.Append("  trxStarted: ").Append(TrxStarted).Append("\n");
            sb.Append("  trxRowsModified: ").Append(TrxRowsModified).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TxnItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TxnItem input)
        {
            if (input == null) return false;
            if (this.TrxId != input.TrxId || (this.TrxId != null && !this.TrxId.Equals(input.TrxId))) return false;
            if (this.EstimatedRemainingTime != input.EstimatedRemainingTime || (this.EstimatedRemainingTime != null && !this.EstimatedRemainingTime.Equals(input.EstimatedRemainingTime))) return false;
            if (this.TrxMysqlThreadId != input.TrxMysqlThreadId || (this.TrxMysqlThreadId != null && !this.TrxMysqlThreadId.Equals(input.TrxMysqlThreadId))) return false;
            if (this.TrxQuery != input.TrxQuery || (this.TrxQuery != null && !this.TrxQuery.Equals(input.TrxQuery))) return false;
            if (this.TrxStarted != input.TrxStarted || (this.TrxStarted != null && !this.TrxStarted.Equals(input.TrxStarted))) return false;
            if (this.TrxRowsModified != input.TrxRowsModified || (this.TrxRowsModified != null && !this.TrxRowsModified.Equals(input.TrxRowsModified))) return false;

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
                if (this.TrxId != null) hashCode = hashCode * 59 + this.TrxId.GetHashCode();
                if (this.EstimatedRemainingTime != null) hashCode = hashCode * 59 + this.EstimatedRemainingTime.GetHashCode();
                if (this.TrxMysqlThreadId != null) hashCode = hashCode * 59 + this.TrxMysqlThreadId.GetHashCode();
                if (this.TrxQuery != null) hashCode = hashCode * 59 + this.TrxQuery.GetHashCode();
                if (this.TrxStarted != null) hashCode = hashCode * 59 + this.TrxStarted.GetHashCode();
                if (this.TrxRowsModified != null) hashCode = hashCode * 59 + this.TrxRowsModified.GetHashCode();
                return hashCode;
            }
        }
    }
}
