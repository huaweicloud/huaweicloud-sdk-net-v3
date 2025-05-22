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
    /// 单条离线全量key分析执行记录
    /// </summary>
    public class OfflineKeyAnalysisRecord 
    {
        /// <summary>
        /// **参数解释**： 离线分析任务状态。 **取值范围**： waiting：任务等待中。 running：任务进行中。 success：任务执行成功。 failed：任务执行失败。 
        /// </summary>
        /// <value>**参数解释**： 离线分析任务状态。 **取值范围**： waiting：任务等待中。 running：任务进行中。 success：任务执行成功。 failed：任务执行失败。 </value>
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
        /// **参数解释**： 任务执行记录ID（此ID对应“查询离线全量key分析详情”参数中的任务ID）。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 离线分析任务状态。 **取值范围**： waiting：任务等待中。 running：任务进行中。 success：任务执行成功。 failed：任务执行失败。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 分析任务创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 分析任务开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("started_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StartedAt { get; set; }

        /// <summary>
        /// **参数解释**： 分析任务结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("finished_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfflineKeyAnalysisRecord {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  startedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  finishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OfflineKeyAnalysisRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OfflineKeyAnalysisRecord input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.StartedAt != input.StartedAt || (this.StartedAt != null && !this.StartedAt.Equals(input.StartedAt))) return false;
            if (this.FinishedAt != input.FinishedAt || (this.FinishedAt != null && !this.FinishedAt.Equals(input.FinishedAt))) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.StartedAt != null) hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.FinishedAt != null) hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
