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
    public class LogTransferDetail 
    {

        /// <summary>
        /// **参数解释：**  OBS转储时间。当创建OBS转储时，必填此参数。与obs_period_unit组合，即\&quot;obs_period\&quot;+\&quot;obs_period_unit\&quot;，必须是\&quot;2min\&quot;, \&quot;5min\&quot;, \&quot;30min\&quot;, \&quot;1hour\&quot;, \&quot;3hour\&quot;, \&quot;6hour\&quot;,\&quot;12hour\&quot;。 **约束限制：**  不涉及。  **取值范围：**  1,2,3,5,6,12,30
        /// </summary>
        [JsonProperty("obs_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? ObsPeriod { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储单位。当创建OBS转储时，必填此参数。与obs_period组合，即\&quot;obs_period\&quot;+\&quot;obs_period_unit\&quot;，必须是\&quot;2min\&quot;, \&quot;5min\&quot;, \&quot;30min\&quot;, \&quot;1hour\&quot;, \&quot;3hour\&quot;, \&quot;6hour\&quot;,\&quot;12hour\&quot;。 **约束限制：**  不涉及。  **取值范围：**  min,hour
        /// </summary>
        [JsonProperty("obs_period_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPeriodUnit { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储日志桶名称。当创建OBS转储时，必填此参数。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储KMS密钥ID。根据OBS转储日志桶是否加密判断，若OBS转储日志加密桶则必须填写该参数，若OBS转储日志桶则不需要此参数 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_encrypted_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsEncryptedId { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储自定义转储路径。当创建OBS转储时，根据需要选填此参数。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_dir_pre_fix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsDirPreFixName { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储日志文件前缀。当创建OBS转储时，根据需要选填此参数。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_prefix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPrefixName { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储时区。参数选择参考OBS转储时区表。如果选择该参数，则必须选择obs_time_zone_id。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTimeZone { get; set; }

        /// <summary>
        /// **参数解释：**  OBS转储时区ID。参数选择参考OBS转储时区表。如果选择该参数，则必须选择obs_time_zone。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_time_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTimeZoneId { get; set; }

        /// <summary>
        /// **参数解释：**  DIS转储通道ID。当创建DIS转储时，必填此参数。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("dis_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DisId { get; set; }

        /// <summary>
        /// **参数解释：**  DIS转储通道名称。当创建DIS转储时，必填此参数。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("dis_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisName { get; set; }

        /// <summary>
        /// **参数解释：**  DMS转储kafka ID。当创建DMS转储时，必填此参数。创建DMS转储前，需要使用kafka ID以及kafka Topic进行实例注册。详情见接口注册DMSkafka实例 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("kafka_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaId { get; set; }

        /// <summary>
        /// **参数解释：**  DMS转储kafka topic。当创建DMS转储时，必填此参数。创建DMS转储前，需要使用kafka ID以及kafka Topic进行实例注册。详情见接口注册DMSkafka实例 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("kafka_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaTopic { get; set; }

        /// <summary>
        /// **参数解释：**  OBS企业项目ID。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsEpsId { get; set; }

        /// <summary>
        /// **参数解释：**  OBS是否开启加密。 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("obs_encrypted_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObsEncryptedEnable { get; set; }

        /// <summary>
        /// **参数解释：**  若开启tag投递，该字段必须包含主机信息：hostIP、hostId、hostName、pathFile、collectTime； 公共字段有：logStreamName、regionName、logGroupName、projectId，为可选填；开启转储标签：streamTag，可选填 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// **参数解释：**  dms转储JSON格式选填，可以转储tag字段 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("lts_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LtsTags { get; set; }

        /// <summary>
        /// **参数解释：**  dms转储JSON格式选填，可以转储日志流标签字段 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("stream_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StreamTags { get; set; }

        /// <summary>
        /// **参数解释：**  dms转储JSON格式选填，可以转储结构化字段 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("struct_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StructFields { get; set; }

        /// <summary>
        /// **参数解释：**  dms转储JSON格式选填，无效字段填充 **约束限制：**  不涉及
        /// </summary>
        [JsonProperty("invalid_field_value", NullValueHandling = NullValueHandling.Ignore)]
        public string InvalidFieldValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogTransferDetail {\n");
            sb.Append("  obsPeriod: ").Append(ObsPeriod).Append("\n");
            sb.Append("  obsPeriodUnit: ").Append(ObsPeriodUnit).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsEncryptedId: ").Append(ObsEncryptedId).Append("\n");
            sb.Append("  obsDirPreFixName: ").Append(ObsDirPreFixName).Append("\n");
            sb.Append("  obsPrefixName: ").Append(ObsPrefixName).Append("\n");
            sb.Append("  obsTimeZone: ").Append(ObsTimeZone).Append("\n");
            sb.Append("  obsTimeZoneId: ").Append(ObsTimeZoneId).Append("\n");
            sb.Append("  disId: ").Append(DisId).Append("\n");
            sb.Append("  disName: ").Append(DisName).Append("\n");
            sb.Append("  kafkaId: ").Append(KafkaId).Append("\n");
            sb.Append("  kafkaTopic: ").Append(KafkaTopic).Append("\n");
            sb.Append("  obsEpsId: ").Append(ObsEpsId).Append("\n");
            sb.Append("  obsEncryptedEnable: ").Append(ObsEncryptedEnable).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  ltsTags: ").Append(LtsTags).Append("\n");
            sb.Append("  streamTags: ").Append(StreamTags).Append("\n");
            sb.Append("  structFields: ").Append(StructFields).Append("\n");
            sb.Append("  invalidFieldValue: ").Append(InvalidFieldValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogTransferDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogTransferDetail input)
        {
            if (input == null) return false;
            if (this.ObsPeriod != input.ObsPeriod || (this.ObsPeriod != null && !this.ObsPeriod.Equals(input.ObsPeriod))) return false;
            if (this.ObsPeriodUnit != input.ObsPeriodUnit || (this.ObsPeriodUnit != null && !this.ObsPeriodUnit.Equals(input.ObsPeriodUnit))) return false;
            if (this.ObsBucketName != input.ObsBucketName || (this.ObsBucketName != null && !this.ObsBucketName.Equals(input.ObsBucketName))) return false;
            if (this.ObsEncryptedId != input.ObsEncryptedId || (this.ObsEncryptedId != null && !this.ObsEncryptedId.Equals(input.ObsEncryptedId))) return false;
            if (this.ObsDirPreFixName != input.ObsDirPreFixName || (this.ObsDirPreFixName != null && !this.ObsDirPreFixName.Equals(input.ObsDirPreFixName))) return false;
            if (this.ObsPrefixName != input.ObsPrefixName || (this.ObsPrefixName != null && !this.ObsPrefixName.Equals(input.ObsPrefixName))) return false;
            if (this.ObsTimeZone != input.ObsTimeZone || (this.ObsTimeZone != null && !this.ObsTimeZone.Equals(input.ObsTimeZone))) return false;
            if (this.ObsTimeZoneId != input.ObsTimeZoneId || (this.ObsTimeZoneId != null && !this.ObsTimeZoneId.Equals(input.ObsTimeZoneId))) return false;
            if (this.DisId != input.DisId || (this.DisId != null && !this.DisId.Equals(input.DisId))) return false;
            if (this.DisName != input.DisName || (this.DisName != null && !this.DisName.Equals(input.DisName))) return false;
            if (this.KafkaId != input.KafkaId || (this.KafkaId != null && !this.KafkaId.Equals(input.KafkaId))) return false;
            if (this.KafkaTopic != input.KafkaTopic || (this.KafkaTopic != null && !this.KafkaTopic.Equals(input.KafkaTopic))) return false;
            if (this.ObsEpsId != input.ObsEpsId || (this.ObsEpsId != null && !this.ObsEpsId.Equals(input.ObsEpsId))) return false;
            if (this.ObsEncryptedEnable != input.ObsEncryptedEnable || (this.ObsEncryptedEnable != null && !this.ObsEncryptedEnable.Equals(input.ObsEncryptedEnable))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.LtsTags != input.LtsTags || (this.LtsTags != null && input.LtsTags != null && !this.LtsTags.SequenceEqual(input.LtsTags))) return false;
            if (this.StreamTags != input.StreamTags || (this.StreamTags != null && input.StreamTags != null && !this.StreamTags.SequenceEqual(input.StreamTags))) return false;
            if (this.StructFields != input.StructFields || (this.StructFields != null && input.StructFields != null && !this.StructFields.SequenceEqual(input.StructFields))) return false;
            if (this.InvalidFieldValue != input.InvalidFieldValue || (this.InvalidFieldValue != null && !this.InvalidFieldValue.Equals(input.InvalidFieldValue))) return false;

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
                if (this.ObsPeriod != null) hashCode = hashCode * 59 + this.ObsPeriod.GetHashCode();
                if (this.ObsPeriodUnit != null) hashCode = hashCode * 59 + this.ObsPeriodUnit.GetHashCode();
                if (this.ObsBucketName != null) hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsEncryptedId != null) hashCode = hashCode * 59 + this.ObsEncryptedId.GetHashCode();
                if (this.ObsDirPreFixName != null) hashCode = hashCode * 59 + this.ObsDirPreFixName.GetHashCode();
                if (this.ObsPrefixName != null) hashCode = hashCode * 59 + this.ObsPrefixName.GetHashCode();
                if (this.ObsTimeZone != null) hashCode = hashCode * 59 + this.ObsTimeZone.GetHashCode();
                if (this.ObsTimeZoneId != null) hashCode = hashCode * 59 + this.ObsTimeZoneId.GetHashCode();
                if (this.DisId != null) hashCode = hashCode * 59 + this.DisId.GetHashCode();
                if (this.DisName != null) hashCode = hashCode * 59 + this.DisName.GetHashCode();
                if (this.KafkaId != null) hashCode = hashCode * 59 + this.KafkaId.GetHashCode();
                if (this.KafkaTopic != null) hashCode = hashCode * 59 + this.KafkaTopic.GetHashCode();
                if (this.ObsEpsId != null) hashCode = hashCode * 59 + this.ObsEpsId.GetHashCode();
                if (this.ObsEncryptedEnable != null) hashCode = hashCode * 59 + this.ObsEncryptedEnable.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LtsTags != null) hashCode = hashCode * 59 + this.LtsTags.GetHashCode();
                if (this.StreamTags != null) hashCode = hashCode * 59 + this.StreamTags.GetHashCode();
                if (this.StructFields != null) hashCode = hashCode * 59 + this.StructFields.GetHashCode();
                if (this.InvalidFieldValue != null) hashCode = hashCode * 59 + this.InvalidFieldValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
