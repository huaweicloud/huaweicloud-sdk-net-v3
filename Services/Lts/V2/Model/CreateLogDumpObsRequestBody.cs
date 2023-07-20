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
    /// 此参数在请求实体中，采用json字符串格式
    /// </summary>
    public class CreateLogDumpObsRequestBody 
    {

        /// <summary>
        /// 日志组id。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志流id列表, 可以指定一个或多个日志流进行obs周期性转储
        /// </summary>
        [JsonProperty("log_stream_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LogStreamIds { get; set; }

        /// <summary>
        /// obs 桶名称。
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// 周期性转储, 必须填 cycle。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 转储格式 RAW/JSON， 默认为 RAW。
        /// </summary>
        [JsonProperty("storage_format", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageFormat { get; set; }

        /// <summary>
        /// 是否开启转储 true/false, 默认为 true
        /// </summary>
        [JsonProperty("switch_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOn { get; set; }

        /// <summary>
        /// 转储至OBS桶中的日志文件前缀。
        /// </summary>
        [JsonProperty("prefix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrefixName { get; set; }

        /// <summary>
        /// 自定义文件夹路径。
        /// </summary>
        [JsonProperty("dir_prefix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DirPrefixName { get; set; }

        /// <summary>
        /// 转储周期的长度， 与 period_unit 拼接后必须在该列表中 [\&quot;2min\&quot;,\&quot;5min\&quot;,\&quot;30min\&quot;,\&quot;1hour\&quot;,\&quot;3hour\&quot;,\&quot;6hour\&quot;,\&quot;12hour\&quot;]。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 转储周期的单位， 与 period 拼接后必须在该列表中 [\&quot;2min\&quot;,\&quot;5min\&quot;,\&quot;30min\&quot;,\&quot;1hour\&quot;,\&quot;3hour\&quot;,\&quot;6hour\&quot;,\&quot;12hour\&quot;]。
        /// </summary>
        [JsonProperty("period_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogDumpObsRequestBody {\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamIds: ").Append(LogStreamIds).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  storageFormat: ").Append(StorageFormat).Append("\n");
            sb.Append("  switchOn: ").Append(SwitchOn).Append("\n");
            sb.Append("  prefixName: ").Append(PrefixName).Append("\n");
            sb.Append("  dirPrefixName: ").Append(DirPrefixName).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  periodUnit: ").Append(PeriodUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogDumpObsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogDumpObsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogStreamIds == input.LogStreamIds ||
                    this.LogStreamIds != null &&
                    input.LogStreamIds != null &&
                    this.LogStreamIds.SequenceEqual(input.LogStreamIds)
                ) && 
                (
                    this.ObsBucketName == input.ObsBucketName ||
                    (this.ObsBucketName != null &&
                    this.ObsBucketName.Equals(input.ObsBucketName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StorageFormat == input.StorageFormat ||
                    (this.StorageFormat != null &&
                    this.StorageFormat.Equals(input.StorageFormat))
                ) && 
                (
                    this.SwitchOn == input.SwitchOn ||
                    (this.SwitchOn != null &&
                    this.SwitchOn.Equals(input.SwitchOn))
                ) && 
                (
                    this.PrefixName == input.PrefixName ||
                    (this.PrefixName != null &&
                    this.PrefixName.Equals(input.PrefixName))
                ) && 
                (
                    this.DirPrefixName == input.DirPrefixName ||
                    (this.DirPrefixName != null &&
                    this.DirPrefixName.Equals(input.DirPrefixName))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PeriodUnit == input.PeriodUnit ||
                    (this.PeriodUnit != null &&
                    this.PeriodUnit.Equals(input.PeriodUnit))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamIds != null)
                    hashCode = hashCode * 59 + this.LogStreamIds.GetHashCode();
                if (this.ObsBucketName != null)
                    hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StorageFormat != null)
                    hashCode = hashCode * 59 + this.StorageFormat.GetHashCode();
                if (this.SwitchOn != null)
                    hashCode = hashCode * 59 + this.SwitchOn.GetHashCode();
                if (this.PrefixName != null)
                    hashCode = hashCode * 59 + this.PrefixName.GetHashCode();
                if (this.DirPrefixName != null)
                    hashCode = hashCode * 59 + this.DirPrefixName.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PeriodUnit != null)
                    hashCode = hashCode * 59 + this.PeriodUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
