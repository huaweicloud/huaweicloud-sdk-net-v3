using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListBackupsDetailsRequest 
    {
        /// <summary>
        /// 备份类型，取值：   \&quot;auto\&quot;：自动全量备份   \&quot;manual\&quot;：手动全量备份
        /// </summary>
        /// <value>备份类型，取值：   \&quot;auto\&quot;：自动全量备份   \&quot;manual\&quot;：手动全量备份</value>
        [JsonConverter(typeof(EnumClassConverter<BackupTypeEnum>))]
        public class BackupTypeEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly BackupTypeEnum AUTO = new BackupTypeEnum("auto");

            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly BackupTypeEnum MANUAL = new BackupTypeEnum("manual");

            private static readonly Dictionary<string, BackupTypeEnum> StaticFields =
            new Dictionary<string, BackupTypeEnum>()
            {
                { "auto", AUTO },
                { "manual", MANUAL },
            };

            private string _value;

            public BackupTypeEnum()
            {

            }

            public BackupTypeEnum(string value)
            {
                _value = value;
            }

            public static BackupTypeEnum FromValue(string value)
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

            public string GetValue()
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

                if (this.Equals(obj as BackupTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackupTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackupTypeEnum a, BackupTypeEnum b)
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

            public static bool operator !=(BackupTypeEnum a, BackupTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份ID。
        /// </summary>
        [SDKProperty("backup_id", IsQuery = true)]
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 备份类型，取值：   \&quot;auto\&quot;：自动全量备份   \&quot;manual\&quot;：手动全量备份
        /// </summary>
        [SDKProperty("backup_type", IsQuery = true)]
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackupTypeEnum BackupType { get; set; }
        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为100，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。与end_time必须同时使用。
        /// </summary>
        [SDKProperty("begin_time", IsQuery = true)]
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”，且大于查询开始时间。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。与begin_time必须同时使用。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupsDetailsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupsDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupsDetailsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.BackupType != input.BackupType) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
