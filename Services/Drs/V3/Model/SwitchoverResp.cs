using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 主备倒换响应体
    /// </summary>
    public class SwitchoverResp 
    {
        /// <summary>
        /// 任务方向。 - up 入云 灾备场景时对应本云为备 - down 出云 灾备场景时对应本云为主 - non-dbs 自建
        /// </summary>
        /// <value>任务方向。 - up 入云 灾备场景时对应本云为备 - down 出云 灾备场景时对应本云为主 - non-dbs 自建</value>
        [JsonConverter(typeof(EnumClassConverter<JobDirectionEnum>))]
        public class JobDirectionEnum
        {
            /// <summary>
            /// Enum UP for value: up
            /// </summary>
            public static readonly JobDirectionEnum UP = new JobDirectionEnum("up");

            /// <summary>
            /// Enum DOWN for value: down
            /// </summary>
            public static readonly JobDirectionEnum DOWN = new JobDirectionEnum("down");

            /// <summary>
            /// Enum NON_DBS for value: non-dbs
            /// </summary>
            public static readonly JobDirectionEnum NON_DBS = new JobDirectionEnum("non-dbs");

            private static readonly Dictionary<string, JobDirectionEnum> StaticFields =
            new Dictionary<string, JobDirectionEnum>()
            {
                { "up", UP },
                { "down", DOWN },
                { "non-dbs", NON_DBS },
            };

            private string _value;

            public JobDirectionEnum()
            {

            }

            public JobDirectionEnum(string value)
            {
                _value = value;
            }

            public static JobDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as JobDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobDirectionEnum a, JobDirectionEnum b)
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

            public static bool operator !=(JobDirectionEnum a, JobDirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 更新时间，格式yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_db", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointVO SourceDb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_db", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointVO TargetDb { get; set; }

        /// <summary>
        /// 任务方向。 - up 入云 灾备场景时对应本云为备 - down 出云 灾备场景时对应本云为主 - non-dbs 自建
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 目标库是否只读。
        /// </summary>
        [JsonProperty("is_target_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTargetReadonly { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchoverResp {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  sourceDb: ").Append(SourceDb).Append("\n");
            sb.Append("  targetDb: ").Append(TargetDb).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  isTargetReadonly: ").Append(IsTargetReadonly).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchoverResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchoverResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.SourceDb == input.SourceDb ||
                    (this.SourceDb != null &&
                    this.SourceDb.Equals(input.SourceDb))
                ) && 
                (
                    this.TargetDb == input.TargetDb ||
                    (this.TargetDb != null &&
                    this.TargetDb.Equals(input.TargetDb))
                ) && 
                (
                    this.JobDirection == input.JobDirection ||
                    (this.JobDirection != null &&
                    this.JobDirection.Equals(input.JobDirection))
                ) && 
                (
                    this.IsTargetReadonly == input.IsTargetReadonly ||
                    (this.IsTargetReadonly != null &&
                    this.IsTargetReadonly.Equals(input.IsTargetReadonly))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.SourceDb != null)
                    hashCode = hashCode * 59 + this.SourceDb.GetHashCode();
                if (this.TargetDb != null)
                    hashCode = hashCode * 59 + this.TargetDb.GetHashCode();
                if (this.JobDirection != null)
                    hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.IsTargetReadonly != null)
                    hashCode = hashCode * 59 + this.IsTargetReadonly.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
