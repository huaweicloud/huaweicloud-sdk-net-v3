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
    /// DDL告警信息响应体。
    /// </summary>
    public class DdlAlarmResp 
    {

        /// <summary>
        /// 记录唯一序号。
        /// </summary>
        [JsonProperty("seqno", NullValueHandling = NullValueHandling.Ignore)]
        public long? Seqno { get; set; }

        /// <summary>
        /// 数据源库位点。
        /// </summary>
        [JsonProperty("checkpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// DDL告警状态。0无告警，1告警中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// DDL在源库执行时间。
        /// </summary>
        [JsonProperty("ddl_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? DdlTimestamp { get; set; }

        /// <summary>
        /// DDL内容。
        /// </summary>
        [JsonProperty("ddl_text", NullValueHandling = NullValueHandling.Ignore)]
        public string DdlText { get; set; }

        /// <summary>
        /// DDL执行结果。false执行失败，true执行成功。
        /// </summary>
        [JsonProperty("exe_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExeResult { get; set; }

        /// <summary>
        /// 数据记录时间。
        /// </summary>
        [JsonProperty("record_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecordTime { get; set; }

        /// <summary>
        /// DDL告警清理时间。
        /// </summary>
        [JsonProperty("clean_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CleanTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DdlAlarmResp {\n");
            sb.Append("  seqno: ").Append(Seqno).Append("\n");
            sb.Append("  checkpoint: ").Append(Checkpoint).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ddlTimestamp: ").Append(DdlTimestamp).Append("\n");
            sb.Append("  ddlText: ").Append(DdlText).Append("\n");
            sb.Append("  exeResult: ").Append(ExeResult).Append("\n");
            sb.Append("  recordTime: ").Append(RecordTime).Append("\n");
            sb.Append("  cleanTime: ").Append(CleanTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DdlAlarmResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DdlAlarmResp input)
        {
            if (input == null) return false;
            if (this.Seqno != input.Seqno || (this.Seqno != null && !this.Seqno.Equals(input.Seqno))) return false;
            if (this.Checkpoint != input.Checkpoint || (this.Checkpoint != null && !this.Checkpoint.Equals(input.Checkpoint))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DdlTimestamp != input.DdlTimestamp || (this.DdlTimestamp != null && !this.DdlTimestamp.Equals(input.DdlTimestamp))) return false;
            if (this.DdlText != input.DdlText || (this.DdlText != null && !this.DdlText.Equals(input.DdlText))) return false;
            if (this.ExeResult != input.ExeResult || (this.ExeResult != null && !this.ExeResult.Equals(input.ExeResult))) return false;
            if (this.RecordTime != input.RecordTime || (this.RecordTime != null && !this.RecordTime.Equals(input.RecordTime))) return false;
            if (this.CleanTime != input.CleanTime || (this.CleanTime != null && !this.CleanTime.Equals(input.CleanTime))) return false;

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
                if (this.Seqno != null) hashCode = hashCode * 59 + this.Seqno.GetHashCode();
                if (this.Checkpoint != null) hashCode = hashCode * 59 + this.Checkpoint.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DdlTimestamp != null) hashCode = hashCode * 59 + this.DdlTimestamp.GetHashCode();
                if (this.DdlText != null) hashCode = hashCode * 59 + this.DdlText.GetHashCode();
                if (this.ExeResult != null) hashCode = hashCode * 59 + this.ExeResult.GetHashCode();
                if (this.RecordTime != null) hashCode = hashCode * 59 + this.RecordTime.GetHashCode();
                if (this.CleanTime != null) hashCode = hashCode * 59 + this.CleanTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
