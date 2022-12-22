using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// 用例运行结果信息
    /// </summary>
    public class JudgementCaseResult 
    {
        /// <summary>
        /// 用例运行结果状态： judgeout判题类型对应：pass（用例比对成功）、failed（用例比对失败）； caseout判题类型对应：success（用例运行成功）、error（用例运行失败）；run_timeout（用例运行超时）
        /// </summary>
        /// <value>用例运行结果状态： judgeout判题类型对应：pass（用例比对成功）、failed（用例比对失败）； caseout判题类型对应：success（用例运行成功）、error（用例运行失败）；run_timeout（用例运行超时）</value>
        [JsonConverter(typeof(EnumClassConverter<CaseStatusEnum>))]
        public class CaseStatusEnum
        {
            /// <summary>
            /// Enum PASS for value: pass
            /// </summary>
            public static readonly CaseStatusEnum PASS = new CaseStatusEnum("pass");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly CaseStatusEnum FAILED = new CaseStatusEnum("failed");

            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly CaseStatusEnum SUCCESS = new CaseStatusEnum("success");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly CaseStatusEnum ERROR = new CaseStatusEnum("error");

            /// <summary>
            /// Enum RUN_TIMEOUT for value: run_timeout
            /// </summary>
            public static readonly CaseStatusEnum RUN_TIMEOUT = new CaseStatusEnum("run_timeout");

            private static readonly Dictionary<string, CaseStatusEnum> StaticFields =
            new Dictionary<string, CaseStatusEnum>()
            {
                { "pass", PASS },
                { "failed", FAILED },
                { "success", SUCCESS },
                { "error", ERROR },
                { "run_timeout", RUN_TIMEOUT },
            };

            private string _value;

            public CaseStatusEnum()
            {

            }

            public CaseStatusEnum(string value)
            {
                _value = value;
            }

            public static CaseStatusEnum FromValue(string value)
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

                if (this.Equals(obj as CaseStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CaseStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CaseStatusEnum a, CaseStatusEnum b)
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

            public static bool operator !=(CaseStatusEnum a, CaseStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用例实际运行结果输出
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        /// <summary>
        /// 用例运行结果状态： judgeout判题类型对应：pass（用例比对成功）、failed（用例比对失败）； caseout判题类型对应：success（用例运行成功）、error（用例运行失败）；run_timeout（用例运行超时）
        /// </summary>
        [JsonProperty("case_status", NullValueHandling = NullValueHandling.Ignore)]
        public CaseStatusEnum CaseStatus { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JudgementCaseResult {\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  caseStatus: ").Append(CaseStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JudgementCaseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JudgementCaseResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.CaseStatus == input.CaseStatus ||
                    (this.CaseStatus != null &&
                    this.CaseStatus.Equals(input.CaseStatus))
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
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.CaseStatus != null)
                    hashCode = hashCode * 59 + this.CaseStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
