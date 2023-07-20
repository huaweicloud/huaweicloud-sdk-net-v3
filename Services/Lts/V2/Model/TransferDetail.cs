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
    /// 日志转储详细信息
    /// </summary>
    public class TransferDetail 
    {
        /// <summary>
        /// OBS转储时间
        /// </summary>
        /// <value>OBS转储时间</value>
        [JsonConverter(typeof(EnumClassConverter<ObsPeriodEnum>))]
        public class ObsPeriodEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_1 = new ObsPeriodEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_2 = new ObsPeriodEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_3 = new ObsPeriodEnum(3);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_5 = new ObsPeriodEnum(5);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_6 = new ObsPeriodEnum(6);

            /// <summary>
            /// Enum NUMBER_12 for value: 12
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_12 = new ObsPeriodEnum(12);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly ObsPeriodEnum NUMBER_30 = new ObsPeriodEnum(30);

            private static readonly Dictionary<int?, ObsPeriodEnum> StaticFields =
            new Dictionary<int?, ObsPeriodEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 5, NUMBER_5 },
                { 6, NUMBER_6 },
                { 12, NUMBER_12 },
                { 30, NUMBER_30 },
            };

            private int? _value;

            public ObsPeriodEnum()
            {

            }

            public ObsPeriodEnum(int? value)
            {
                _value = value;
            }

            public static ObsPeriodEnum FromValue(int? value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public int? GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ObsPeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObsPeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObsPeriodEnum a, ObsPeriodEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ObsPeriodEnum a, ObsPeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// OBS转储时间
        /// </summary>
        [JsonProperty("obs_period", NullValueHandling = NullValueHandling.Ignore)]
        public ObsPeriodEnum ObsPeriod { get; set; }
        /// <summary>
        /// OBS转储KMS秘钥ID。若OBS转储未加密则不返回此字段
        /// </summary>
        [JsonProperty("obs_encrypted_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsEncryptedId { get; set; }

        /// <summary>
        /// OBS转储日志文件前缀
        /// </summary>
        [JsonProperty("obs_prefix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPrefixName { get; set; }

        /// <summary>
        /// OBS转储单位
        /// </summary>
        [JsonProperty("obs_period_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPeriodUnit { get; set; }

        /// <summary>
        /// OBS转储路径，指OBS日志桶中的路径
        /// </summary>
        [JsonProperty("obs_transfer_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTransferPath { get; set; }

        /// <summary>
        /// OBS企业项目ID
        /// </summary>
        [JsonProperty("obs_eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsEpsId { get; set; }

        /// <summary>
        /// OBS日志桶名称
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// OBS是否开启加密。
        /// </summary>
        [JsonProperty("obs_encrypted_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObsEncryptedEnable { get; set; }

        /// <summary>
        /// OBS转储自定义转储路径
        /// </summary>
        [JsonProperty("obs_dir_pre_fix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsDirPreFixName { get; set; }

        /// <summary>
        /// DIS转储通道ID
        /// </summary>
        [JsonProperty("dis_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DisId { get; set; }

        /// <summary>
        /// DIS转储通道名称
        /// </summary>
        [JsonProperty("dis_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisName { get; set; }

        /// <summary>
        /// DMS转储kafka ID
        /// </summary>
        [JsonProperty("kafka_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaId { get; set; }

        /// <summary>
        /// DMS转储kafka topic
        /// </summary>
        [JsonProperty("kafka_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaTopic { get; set; }

        /// <summary>
        /// OBS转储时区。如果选择该参数，则必须选择obs_time_zone_id。
        /// </summary>
        [JsonProperty("obs_time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTimeZone { get; set; }

        /// <summary>
        /// OBS转储时区ID。参数选择参考OBS转储时区表。如果选择该参数，则必须选择obs_time_zone。
        /// </summary>
        [JsonProperty("obs_time_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTimeZoneId { get; set; }

        /// <summary>
        /// 若开启tag投递，该字段必须包含主机信息：hostIP、hostId、hostName、pathFile、collectTime；  公共字段有：logStreamName、regionName、logGroupName、projectId，为可选填；  开启转储标签：streamTag，可选填
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferDetail {\n");
            sb.Append("  obsPeriod: ").Append(ObsPeriod).Append("\n");
            sb.Append("  obsEncryptedId: ").Append(ObsEncryptedId).Append("\n");
            sb.Append("  obsPrefixName: ").Append(ObsPrefixName).Append("\n");
            sb.Append("  obsPeriodUnit: ").Append(ObsPeriodUnit).Append("\n");
            sb.Append("  obsTransferPath: ").Append(ObsTransferPath).Append("\n");
            sb.Append("  obsEpsId: ").Append(ObsEpsId).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsEncryptedEnable: ").Append(ObsEncryptedEnable).Append("\n");
            sb.Append("  obsDirPreFixName: ").Append(ObsDirPreFixName).Append("\n");
            sb.Append("  disId: ").Append(DisId).Append("\n");
            sb.Append("  disName: ").Append(DisName).Append("\n");
            sb.Append("  kafkaId: ").Append(KafkaId).Append("\n");
            sb.Append("  kafkaTopic: ").Append(KafkaTopic).Append("\n");
            sb.Append("  obsTimeZone: ").Append(ObsTimeZone).Append("\n");
            sb.Append("  obsTimeZoneId: ").Append(ObsTimeZoneId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObsPeriod == input.ObsPeriod ||
                    (this.ObsPeriod != null &&
                    this.ObsPeriod.Equals(input.ObsPeriod))
                ) && 
                (
                    this.ObsEncryptedId == input.ObsEncryptedId ||
                    (this.ObsEncryptedId != null &&
                    this.ObsEncryptedId.Equals(input.ObsEncryptedId))
                ) && 
                (
                    this.ObsPrefixName == input.ObsPrefixName ||
                    (this.ObsPrefixName != null &&
                    this.ObsPrefixName.Equals(input.ObsPrefixName))
                ) && 
                (
                    this.ObsPeriodUnit == input.ObsPeriodUnit ||
                    (this.ObsPeriodUnit != null &&
                    this.ObsPeriodUnit.Equals(input.ObsPeriodUnit))
                ) && 
                (
                    this.ObsTransferPath == input.ObsTransferPath ||
                    (this.ObsTransferPath != null &&
                    this.ObsTransferPath.Equals(input.ObsTransferPath))
                ) && 
                (
                    this.ObsEpsId == input.ObsEpsId ||
                    (this.ObsEpsId != null &&
                    this.ObsEpsId.Equals(input.ObsEpsId))
                ) && 
                (
                    this.ObsBucketName == input.ObsBucketName ||
                    (this.ObsBucketName != null &&
                    this.ObsBucketName.Equals(input.ObsBucketName))
                ) && 
                (
                    this.ObsEncryptedEnable == input.ObsEncryptedEnable ||
                    (this.ObsEncryptedEnable != null &&
                    this.ObsEncryptedEnable.Equals(input.ObsEncryptedEnable))
                ) && 
                (
                    this.ObsDirPreFixName == input.ObsDirPreFixName ||
                    (this.ObsDirPreFixName != null &&
                    this.ObsDirPreFixName.Equals(input.ObsDirPreFixName))
                ) && 
                (
                    this.DisId == input.DisId ||
                    (this.DisId != null &&
                    this.DisId.Equals(input.DisId))
                ) && 
                (
                    this.DisName == input.DisName ||
                    (this.DisName != null &&
                    this.DisName.Equals(input.DisName))
                ) && 
                (
                    this.KafkaId == input.KafkaId ||
                    (this.KafkaId != null &&
                    this.KafkaId.Equals(input.KafkaId))
                ) && 
                (
                    this.KafkaTopic == input.KafkaTopic ||
                    (this.KafkaTopic != null &&
                    this.KafkaTopic.Equals(input.KafkaTopic))
                ) && 
                (
                    this.ObsTimeZone == input.ObsTimeZone ||
                    (this.ObsTimeZone != null &&
                    this.ObsTimeZone.Equals(input.ObsTimeZone))
                ) && 
                (
                    this.ObsTimeZoneId == input.ObsTimeZoneId ||
                    (this.ObsTimeZoneId != null &&
                    this.ObsTimeZoneId.Equals(input.ObsTimeZoneId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.ObsPeriod != null)
                    hashCode = hashCode * 59 + this.ObsPeriod.GetHashCode();
                if (this.ObsEncryptedId != null)
                    hashCode = hashCode * 59 + this.ObsEncryptedId.GetHashCode();
                if (this.ObsPrefixName != null)
                    hashCode = hashCode * 59 + this.ObsPrefixName.GetHashCode();
                if (this.ObsPeriodUnit != null)
                    hashCode = hashCode * 59 + this.ObsPeriodUnit.GetHashCode();
                if (this.ObsTransferPath != null)
                    hashCode = hashCode * 59 + this.ObsTransferPath.GetHashCode();
                if (this.ObsEpsId != null)
                    hashCode = hashCode * 59 + this.ObsEpsId.GetHashCode();
                if (this.ObsBucketName != null)
                    hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsEncryptedEnable != null)
                    hashCode = hashCode * 59 + this.ObsEncryptedEnable.GetHashCode();
                if (this.ObsDirPreFixName != null)
                    hashCode = hashCode * 59 + this.ObsDirPreFixName.GetHashCode();
                if (this.DisId != null)
                    hashCode = hashCode * 59 + this.DisId.GetHashCode();
                if (this.DisName != null)
                    hashCode = hashCode * 59 + this.DisName.GetHashCode();
                if (this.KafkaId != null)
                    hashCode = hashCode * 59 + this.KafkaId.GetHashCode();
                if (this.KafkaTopic != null)
                    hashCode = hashCode * 59 + this.KafkaTopic.GetHashCode();
                if (this.ObsTimeZone != null)
                    hashCode = hashCode * 59 + this.ObsTimeZone.GetHashCode();
                if (this.ObsTimeZoneId != null)
                    hashCode = hashCode * 59 + this.ObsTimeZoneId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
