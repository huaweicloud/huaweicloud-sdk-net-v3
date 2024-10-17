using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHotkeyTaskDetailsResponse : SdkResponse
    {
        /// <summary>
        /// 分析任务状态
        /// </summary>
        /// <value>分析任务状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("waiting");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("running");

            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "waiting", WAITING },
                { "running", RUNNING },
                { "success", SUCCESS },
                { "failed", FAILED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分析方式
        /// </summary>
        /// <value>分析方式</value>
        [JsonConverter(typeof(EnumClassConverter<ScanTypeEnum>))]
        public class ScanTypeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly ScanTypeEnum MANUAL = new ScanTypeEnum("manual");

            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly ScanTypeEnum AUTO = new ScanTypeEnum("auto");

            private static readonly Dictionary<string, ScanTypeEnum> StaticFields =
            new Dictionary<string, ScanTypeEnum>()
            {
                { "manual", MANUAL },
                { "auto", AUTO },
            };

            private string _value;

            public ScanTypeEnum()
            {

            }

            public ScanTypeEnum(string value)
            {
                _value = value;
            }

            public static ScanTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScanTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScanTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScanTypeEnum a, ScanTypeEnum b)
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

            public static bool operator !=(ScanTypeEnum a, ScanTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 热key分析记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 分析任务状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 分析方式
        /// </summary>
        [JsonProperty("scan_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScanTypeEnum ScanType { get; set; }
        /// <summary>
        /// 分析任务创建时间,格式为：\&quot;2020-06-15T02:21:18.669Z\&quot;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 分析任务开始时间,格式为：\&quot;2020-06-15T02:21:18.669Z\&quot;
        /// </summary>
        [JsonProperty("started_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StartedAt { get; set; }

        /// <summary>
        /// 分析任务结束时间,格式为：\&quot;2020-06-15T02:21:18.669Z\&quot;
        /// </summary>
        [JsonProperty("finished_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// 热key的数量
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public int? Num { get; set; }

        /// <summary>
        /// 热key记录
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<HotkeysBody> Keys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHotkeyTaskDetailsResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  scanType: ").Append(ScanType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  startedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  finishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHotkeyTaskDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHotkeyTaskDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status) return false;
            if (this.ScanType != input.ScanType) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.StartedAt != input.StartedAt || (this.StartedAt != null && !this.StartedAt.Equals(input.StartedAt))) return false;
            if (this.FinishedAt != input.FinishedAt || (this.FinishedAt != null && !this.FinishedAt.Equals(input.FinishedAt))) return false;
            if (this.Num != input.Num || (this.Num != null && !this.Num.Equals(input.Num))) return false;
            if (this.Keys != input.Keys || (this.Keys != null && input.Keys != null && !this.Keys.SequenceEqual(input.Keys))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ScanType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.StartedAt != null) hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.FinishedAt != null) hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Num != null) hashCode = hashCode * 59 + this.Num.GetHashCode();
                if (this.Keys != null) hashCode = hashCode * 59 + this.Keys.GetHashCode();
                return hashCode;
            }
        }
    }
}
