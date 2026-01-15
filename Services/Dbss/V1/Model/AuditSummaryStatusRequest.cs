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
    public class AuditSummaryStatusRequest 
    {

        /// <summary>
        /// 操作码，operType为switch时必输入  - on：开启  - off：关闭
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 操作类型  - switch：任务开关  - execute：立即刷新
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// 查询条件：开始时间
        /// </summary>
        [JsonProperty("query_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryBeginTime { get; set; }

        /// <summary>
        /// 查询条件：结束时间
        /// </summary>
        [JsonProperty("query_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSummaryStatusRequest {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  operType: ").Append(OperType).Append("\n");
            sb.Append("  queryBeginTime: ").Append(QueryBeginTime).Append("\n");
            sb.Append("  queryEndTime: ").Append(QueryEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditSummaryStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditSummaryStatusRequest input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.OperType != input.OperType || (this.OperType != null && !this.OperType.Equals(input.OperType))) return false;
            if (this.QueryBeginTime != input.QueryBeginTime || (this.QueryBeginTime != null && !this.QueryBeginTime.Equals(input.QueryBeginTime))) return false;
            if (this.QueryEndTime != input.QueryEndTime || (this.QueryEndTime != null && !this.QueryEndTime.Equals(input.QueryEndTime))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.OperType != null) hashCode = hashCode * 59 + this.OperType.GetHashCode();
                if (this.QueryBeginTime != null) hashCode = hashCode * 59 + this.QueryBeginTime.GetHashCode();
                if (this.QueryEndTime != null) hashCode = hashCode * 59 + this.QueryEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
