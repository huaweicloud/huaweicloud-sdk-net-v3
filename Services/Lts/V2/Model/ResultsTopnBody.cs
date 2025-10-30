using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResultsTopnBody 
    {

        /// <summary>
        /// 索引流量，byte, 查询数据类型中包含index时返回
        /// </summary>
        [JsonProperty("index_traffic", NullValueHandling = NullValueHandling.Ignore)]
        public double? IndexTraffic { get; set; }

        /// <summary>
        /// 存储量，byte, 查询数据类型中包含storage时返回
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Storage { get; set; }

        /// <summary>
        /// 写入流量，byte, 查询数据类型中包含write时返回
        /// </summary>
        [JsonProperty("write_traffic", NullValueHandling = NullValueHandling.Ignore)]
        public double? WriteTraffic { get; set; }

        /// <summary>
        /// 日志组id，资源类型为日志组时返回
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志组名称，资源类型为日志组时返回
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// **参数解释：** 日志组名称别名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_group_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupNameAlias { get; set; }

        /// <summary>
        /// 日志流id，资源类型为日志流时返回
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称，资源类型为日志流时返回
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// **参数解释：** 日志流名称别名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("log_stream_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamNameAlias { get; set; }

        /// <summary>
        /// 基础转储流量，byte, 查询数据类型中包含basicTransfer时返回
        /// </summary>
        [JsonProperty("basic_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public double? BasicTransfer { get; set; }

        /// <summary>
        /// 基础转储流量，byte, 查询数据类型中包含seniorTransfer时返回
        /// </summary>
        [JsonProperty("senior_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public double? SeniorTransfer { get; set; }

        /// <summary>
        /// 不是委托转储，true，是委托转储，则前端资源统计展示的流不能跳
        /// </summary>
        [JsonProperty("is_agency_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAgencyTransfer { get; set; }

        /// <summary>
        /// 冷存储量
        /// </summary>
        [JsonProperty("cold_storage", NullValueHandling = NullValueHandling.Ignore)]
        public double? ColdStorage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultsTopnBody {\n");
            sb.Append("  indexTraffic: ").Append(IndexTraffic).Append("\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  writeTraffic: ").Append(WriteTraffic).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logGroupNameAlias: ").Append(LogGroupNameAlias).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  logStreamNameAlias: ").Append(LogStreamNameAlias).Append("\n");
            sb.Append("  basicTransfer: ").Append(BasicTransfer).Append("\n");
            sb.Append("  seniorTransfer: ").Append(SeniorTransfer).Append("\n");
            sb.Append("  isAgencyTransfer: ").Append(IsAgencyTransfer).Append("\n");
            sb.Append("  coldStorage: ").Append(ColdStorage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResultsTopnBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResultsTopnBody input)
        {
            if (input == null) return false;
            if (this.IndexTraffic != input.IndexTraffic || (this.IndexTraffic != null && !this.IndexTraffic.Equals(input.IndexTraffic))) return false;
            if (this.Storage != input.Storage || (this.Storage != null && !this.Storage.Equals(input.Storage))) return false;
            if (this.WriteTraffic != input.WriteTraffic || (this.WriteTraffic != null && !this.WriteTraffic.Equals(input.WriteTraffic))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogGroupNameAlias != input.LogGroupNameAlias || (this.LogGroupNameAlias != null && !this.LogGroupNameAlias.Equals(input.LogGroupNameAlias))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.LogStreamNameAlias != input.LogStreamNameAlias || (this.LogStreamNameAlias != null && !this.LogStreamNameAlias.Equals(input.LogStreamNameAlias))) return false;
            if (this.BasicTransfer != input.BasicTransfer || (this.BasicTransfer != null && !this.BasicTransfer.Equals(input.BasicTransfer))) return false;
            if (this.SeniorTransfer != input.SeniorTransfer || (this.SeniorTransfer != null && !this.SeniorTransfer.Equals(input.SeniorTransfer))) return false;
            if (this.IsAgencyTransfer != input.IsAgencyTransfer || (this.IsAgencyTransfer != null && !this.IsAgencyTransfer.Equals(input.IsAgencyTransfer))) return false;
            if (this.ColdStorage != input.ColdStorage || (this.ColdStorage != null && !this.ColdStorage.Equals(input.ColdStorage))) return false;

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
                if (this.IndexTraffic != null) hashCode = hashCode * 59 + this.IndexTraffic.GetHashCode();
                if (this.Storage != null) hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.WriteTraffic != null) hashCode = hashCode * 59 + this.WriteTraffic.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogGroupNameAlias != null) hashCode = hashCode * 59 + this.LogGroupNameAlias.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.LogStreamNameAlias != null) hashCode = hashCode * 59 + this.LogStreamNameAlias.GetHashCode();
                if (this.BasicTransfer != null) hashCode = hashCode * 59 + this.BasicTransfer.GetHashCode();
                if (this.SeniorTransfer != null) hashCode = hashCode * 59 + this.SeniorTransfer.GetHashCode();
                if (this.IsAgencyTransfer != null) hashCode = hashCode * 59 + this.IsAgencyTransfer.GetHashCode();
                if (this.ColdStorage != null) hashCode = hashCode * 59 + this.ColdStorage.GetHashCode();
                return hashCode;
            }
        }
    }
}
