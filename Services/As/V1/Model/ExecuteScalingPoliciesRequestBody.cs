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
    public class ExecuteScalingPoliciesRequestBody 
    {
        /// <summary>
        /// 批量操作伸缩策略action标识：删除：delete。启用：resume。停止：pause。
        /// </summary>
        /// <value>批量操作伸缩策略action标识：删除：delete。启用：resume。停止：pause。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("delete");

            /// <summary>
            /// Enum RESUME for value: resume
            /// </summary>
            public static readonly ActionEnum RESUME = new ActionEnum("resume");

            /// <summary>
            /// Enum PAUSE for value: pause
            /// </summary>
            public static readonly ActionEnum PAUSE = new ActionEnum("pause");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "delete", DELETE },
                { "resume", RESUME },
                { "pause", PAUSE },
            };

            private string Value;

            public ActionEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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
        public string ForceDelete { get; set; }

        /// <summary>
        /// 批量操作伸缩策略action标识：删除：delete。启用：resume。停止：pause。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteScalingPoliciesRequestBody {\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  forceDelete: ").Append(ForceDelete).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteScalingPoliciesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteScalingPoliciesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingPolicyId == input.ScalingPolicyId ||
                    this.ScalingPolicyId != null &&
                    input.ScalingPolicyId != null &&
                    this.ScalingPolicyId.SequenceEqual(input.ScalingPolicyId)
                ) && 
                (
                    this.ForceDelete == input.ForceDelete ||
                    (this.ForceDelete != null &&
                    this.ForceDelete.Equals(input.ForceDelete))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.ScalingPolicyId != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                if (this.ForceDelete != null)
                    hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
