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
    /// 预检查项结果。
    /// </summary>
    public class PrecheckResult 
    {
        /// <summary>
        /// 检查结果。取值： - PASSED：检查通过。 - ALARM：检查告警项。 - FAILED：检查失败。
        /// </summary>
        /// <value>检查结果。取值： - PASSED：检查通过。 - ALARM：检查告警项。 - FAILED：检查失败。</value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum PASSED for value: PASSED
            /// </summary>
            public static readonly ResultEnum PASSED = new ResultEnum("PASSED");

            /// <summary>
            /// Enum ALARM for value: ALARM
            /// </summary>
            public static readonly ResultEnum ALARM = new ResultEnum("ALARM");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("FAILED");

            private static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                { "PASSED", PASSED },
                { "ALARM", ALARM },
                { "FAILED", FAILED },
            };

            private string _value;

            public ResultEnum()
            {

            }

            public ResultEnum(string value)
            {
                _value = value;
            }

            public static ResultEnum FromValue(string value)
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

                if (this.Equals(obj as ResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 检查项。
        /// </summary>
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>
        /// 检查结果。取值： - PASSED：检查通过。 - ALARM：检查告警项。 - FAILED：检查失败。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 失败数据。
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// 失败详情。
        /// </summary>
        [JsonProperty("raw_error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string RawErrorMsg { get; set; }

        /// <summary>
        /// 检查项分组。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// 是否支持跳过。
        /// </summary>
        [JsonProperty("is_support_skip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportSkip { get; set; }

        /// <summary>
        /// 是否已跳过。
        /// </summary>
        [JsonProperty("is_skipped", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSkipped { get; set; }

        /// <summary>
        /// 失败子任务详情。
        /// </summary>
        [JsonProperty("failed_sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrecheckFailSubJobResult> FailedSubJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckResult {\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  rawErrorMsg: ").Append(RawErrorMsg).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  isSupportSkip: ").Append(IsSupportSkip).Append("\n");
            sb.Append("  isSkipped: ").Append(IsSkipped).Append("\n");
            sb.Append("  failedSubJobs: ").Append(FailedSubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.FailedReason == input.FailedReason ||
                    (this.FailedReason != null &&
                    this.FailedReason.Equals(input.FailedReason))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.RawErrorMsg == input.RawErrorMsg ||
                    (this.RawErrorMsg != null &&
                    this.RawErrorMsg.Equals(input.RawErrorMsg))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.IsSupportSkip == input.IsSupportSkip ||
                    (this.IsSupportSkip != null &&
                    this.IsSupportSkip.Equals(input.IsSupportSkip))
                ) && 
                (
                    this.IsSkipped == input.IsSkipped ||
                    (this.IsSkipped != null &&
                    this.IsSkipped.Equals(input.IsSkipped))
                ) && 
                (
                    this.FailedSubJobs == input.FailedSubJobs ||
                    this.FailedSubJobs != null &&
                    input.FailedSubJobs != null &&
                    this.FailedSubJobs.SequenceEqual(input.FailedSubJobs)
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
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.FailedReason != null)
                    hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.RawErrorMsg != null)
                    hashCode = hashCode * 59 + this.RawErrorMsg.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.IsSupportSkip != null)
                    hashCode = hashCode * 59 + this.IsSupportSkip.GetHashCode();
                if (this.IsSkipped != null)
                    hashCode = hashCode * 59 + this.IsSkipped.GetHashCode();
                if (this.FailedSubJobs != null)
                    hashCode = hashCode * 59 + this.FailedSubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
