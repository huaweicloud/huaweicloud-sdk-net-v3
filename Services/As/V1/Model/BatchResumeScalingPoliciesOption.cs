using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 批量操作弹性伸缩策略
    /// </summary>
    public class BatchResumeScalingPoliciesOption 
    {
        /// <summary>
        /// 是否强制删除伸缩策略。默认为no，可选值为yes或no。只有action为delete时，该字段才生效。
        /// </summary>
        /// <value>是否强制删除伸缩策略。默认为no，可选值为yes或no。只有action为delete时，该字段才生效。</value>
        [JsonConverter(typeof(EnumClassConverter<ForceDeleteEnum>))]
        public class ForceDeleteEnum
        {
            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly ForceDeleteEnum NO = new ForceDeleteEnum("no");

            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly ForceDeleteEnum YES = new ForceDeleteEnum("yes");

            private static readonly Dictionary<string, ForceDeleteEnum> StaticFields =
            new Dictionary<string, ForceDeleteEnum>()
            {
                { "no", NO },
                { "yes", YES },
            };

            private string _value;

            public ForceDeleteEnum()
            {

            }

            public ForceDeleteEnum(string value)
            {
                _value = value;
            }

            public static ForceDeleteEnum FromValue(string value)
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

                if (this.Equals(obj as ForceDeleteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ForceDeleteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ForceDeleteEnum a, ForceDeleteEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ForceDeleteEnum a, ForceDeleteEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 批量操作伸缩策略action标识：删除：delete。启用：resume。停止：pause。
        /// </summary>
        /// <value>批量操作伸缩策略action标识：删除：delete。启用：resume。停止：pause。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum RESUME for value: resume
            /// </summary>
            public static readonly ActionEnum RESUME = new ActionEnum("resume");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "resume", RESUME },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScalingPolicyId { get; set; }

        /// <summary>
        /// 是否强制删除伸缩策略。默认为no，可选值为yes或no。只有action为delete时，该字段才生效。
        /// </summary>
        [JsonProperty("force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public ForceDeleteEnum ForceDelete { get; set; }
        /// <summary>
        /// 批量操作伸缩策略action标识：删除：delete。启用：resume。停止：pause。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 是否删除告警策略使用的告警规则。可选值为yes或no，默认为no。 只有action为delete时，该字段才生效。
        /// </summary>
        [JsonProperty("delete_alarm", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteAlarm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResumeScalingPoliciesOption {\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  forceDelete: ").Append(ForceDelete).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  deleteAlarm: ").Append(DeleteAlarm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResumeScalingPoliciesOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResumeScalingPoliciesOption input)
        {
            if (input == null) return false;
            if (this.ScalingPolicyId != input.ScalingPolicyId || (this.ScalingPolicyId != null && input.ScalingPolicyId != null && !this.ScalingPolicyId.SequenceEqual(input.ScalingPolicyId))) return false;
            if (this.ForceDelete != input.ForceDelete) return false;
            if (this.Action != input.Action) return false;
            if (this.DeleteAlarm != input.DeleteAlarm || (this.DeleteAlarm != null && !this.DeleteAlarm.Equals(input.DeleteAlarm))) return false;

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
                if (this.ScalingPolicyId != null) hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.DeleteAlarm != null) hashCode = hashCode * 59 + this.DeleteAlarm.GetHashCode();
                return hashCode;
            }
        }
    }
}
