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
    /// 获取预检查结果返回体
    /// </summary>
    public class QueryPreCheckResp 
    {
        /// <summary>
        /// 迁移方向。 - up-入云 灾备场景时对应本云为备 - down-出云 灾备场景时对应本云为主 - non-dbs-自建
        /// </summary>
        /// <value>迁移方向。 - up-入云 灾备场景时对应本云为备 - down-出云 灾备场景时对应本云为主 - non-dbs-自建</value>
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
        /// 预检查id。
        /// </summary>
        [JsonProperty("precheck_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrecheckId { get; set; }

        /// <summary>
        /// 返回的预检查结果是否通过。true表示预检查通过，通过后才可进行启动任务。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; }

        /// <summary>
        /// 预检查进度百分比。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public string Process { get; set; }

        /// <summary>
        /// 预检查通过百分比。
        /// </summary>
        [JsonProperty("total_passed_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPassedRate { get; set; }

        /// <summary>
        /// RDS实例id。
        /// </summary>
        [JsonProperty("rds_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsInstanceId { get; set; }

        /// <summary>
        /// 迁移方向。 - up-入云 灾备场景时对应本云为备 - down-出云 灾备场景时对应本云为主 - non-dbs-自建
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 预检查各项结果。
        /// </summary>
        [JsonProperty("precheck_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrecheckResult> PrecheckResult { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 任务错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryPreCheckResp {\n");
            sb.Append("  precheckId: ").Append(PrecheckId).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  totalPassedRate: ").Append(TotalPassedRate).Append("\n");
            sb.Append("  rdsInstanceId: ").Append(RdsInstanceId).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  precheckResult: ").Append(PrecheckResult).Append("\n");
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
            return this.Equals(input as QueryPreCheckResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryPreCheckResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrecheckId == input.PrecheckId ||
                    (this.PrecheckId != null &&
                    this.PrecheckId.Equals(input.PrecheckId))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.TotalPassedRate == input.TotalPassedRate ||
                    (this.TotalPassedRate != null &&
                    this.TotalPassedRate.Equals(input.TotalPassedRate))
                ) && 
                (
                    this.RdsInstanceId == input.RdsInstanceId ||
                    (this.RdsInstanceId != null &&
                    this.RdsInstanceId.Equals(input.RdsInstanceId))
                ) && 
                (
                    this.JobDirection == input.JobDirection ||
                    (this.JobDirection != null &&
                    this.JobDirection.Equals(input.JobDirection))
                ) && 
                (
                    this.PrecheckResult == input.PrecheckResult ||
                    this.PrecheckResult != null &&
                    input.PrecheckResult != null &&
                    this.PrecheckResult.SequenceEqual(input.PrecheckResult)
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
                if (this.PrecheckId != null)
                    hashCode = hashCode * 59 + this.PrecheckId.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Process != null)
                    hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.TotalPassedRate != null)
                    hashCode = hashCode * 59 + this.TotalPassedRate.GetHashCode();
                if (this.RdsInstanceId != null)
                    hashCode = hashCode * 59 + this.RdsInstanceId.GetHashCode();
                if (this.JobDirection != null)
                    hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.PrecheckResult != null)
                    hashCode = hashCode * 59 + this.PrecheckResult.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
