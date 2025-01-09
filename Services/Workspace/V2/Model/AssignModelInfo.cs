using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量分配桌面策略。
    /// </summary>
    public class AssignModelInfo 
    {
        /// <summary>
        /// 分配的维度，当前支持  - USER: “用户为维度” - DESKTOP:“桌面为维度”两种。
        /// </summary>
        /// <value>分配的维度，当前支持  - USER: “用户为维度” - DESKTOP:“桌面为维度”两种。</value>
        [JsonConverter(typeof(EnumClassConverter<AssignDimensionEnum>))]
        public class AssignDimensionEnum
        {
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly AssignDimensionEnum USER = new AssignDimensionEnum("USER");

            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            public static readonly AssignDimensionEnum DESKTOP = new AssignDimensionEnum("DESKTOP");

            private static readonly Dictionary<string, AssignDimensionEnum> StaticFields =
            new Dictionary<string, AssignDimensionEnum>()
            {
                { "USER", USER },
                { "DESKTOP", DESKTOP },
            };

            private string _value;

            public AssignDimensionEnum()
            {

            }

            public AssignDimensionEnum(string value)
            {
                _value = value;
            }

            public static AssignDimensionEnum FromValue(string value)
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

                if (this.Equals(obj as AssignDimensionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssignDimensionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssignDimensionEnum a, AssignDimensionEnum b)
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

            public static bool operator !=(AssignDimensionEnum a, AssignDimensionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 优先分配的策略，策略名为规则为{维度}_{子策略}  - USER_NO_DESKTOP:  用户维度-无桌面 - USER_FIXED_DESKTOP_NUM: 用户维度-桌面个数固定 - DESKTOP_ASSIGN_USER_PRIORITY： 桌面维度-用户优先 - DESKTOP_ASSIGN_FIXED_USER： 桌面维度-固定用户 - DESKTOP_ASSIGN_USERS_OR_GROUPS： 桌面维度-为每台桌面分配所选的所有用户（组） - FIXED_RELATION: 使用参数中的固定分配关系
        /// </summary>
        /// <value>优先分配的策略，策略名为规则为{维度}_{子策略}  - USER_NO_DESKTOP:  用户维度-无桌面 - USER_FIXED_DESKTOP_NUM: 用户维度-桌面个数固定 - DESKTOP_ASSIGN_USER_PRIORITY： 桌面维度-用户优先 - DESKTOP_ASSIGN_FIXED_USER： 桌面维度-固定用户 - DESKTOP_ASSIGN_USERS_OR_GROUPS： 桌面维度-为每台桌面分配所选的所有用户（组） - FIXED_RELATION: 使用参数中的固定分配关系</value>
        [JsonConverter(typeof(EnumClassConverter<PriorityStrategyEnum>))]
        public class PriorityStrategyEnum
        {
            /// <summary>
            /// Enum USER_NO_DESKTOP for value: USER_NO_DESKTOP
            /// </summary>
            public static readonly PriorityStrategyEnum USER_NO_DESKTOP = new PriorityStrategyEnum("USER_NO_DESKTOP");

            /// <summary>
            /// Enum USER_FIXED_DESKTOP_NUM for value: USER_FIXED_DESKTOP_NUM
            /// </summary>
            public static readonly PriorityStrategyEnum USER_FIXED_DESKTOP_NUM = new PriorityStrategyEnum("USER_FIXED_DESKTOP_NUM");

            /// <summary>
            /// Enum DESKTOP_ASSIGN_USER_PRIORITY for value: DESKTOP_ASSIGN_USER_PRIORITY
            /// </summary>
            public static readonly PriorityStrategyEnum DESKTOP_ASSIGN_USER_PRIORITY = new PriorityStrategyEnum("DESKTOP_ASSIGN_USER_PRIORITY");

            /// <summary>
            /// Enum DESKTOP_ASSIGN_FIXED_USER for value: DESKTOP_ASSIGN_FIXED_USER
            /// </summary>
            public static readonly PriorityStrategyEnum DESKTOP_ASSIGN_FIXED_USER = new PriorityStrategyEnum("DESKTOP_ASSIGN_FIXED_USER");

            /// <summary>
            /// Enum DESKTOP_ASSIGN_USERS_OR_GROUPS for value: DESKTOP_ASSIGN_USERS_OR_GROUPS
            /// </summary>
            public static readonly PriorityStrategyEnum DESKTOP_ASSIGN_USERS_OR_GROUPS = new PriorityStrategyEnum("DESKTOP_ASSIGN_USERS_OR_GROUPS");

            /// <summary>
            /// Enum FIXED_RELATION for value: FIXED_RELATION
            /// </summary>
            public static readonly PriorityStrategyEnum FIXED_RELATION = new PriorityStrategyEnum("FIXED_RELATION");

            private static readonly Dictionary<string, PriorityStrategyEnum> StaticFields =
            new Dictionary<string, PriorityStrategyEnum>()
            {
                { "USER_NO_DESKTOP", USER_NO_DESKTOP },
                { "USER_FIXED_DESKTOP_NUM", USER_FIXED_DESKTOP_NUM },
                { "DESKTOP_ASSIGN_USER_PRIORITY", DESKTOP_ASSIGN_USER_PRIORITY },
                { "DESKTOP_ASSIGN_FIXED_USER", DESKTOP_ASSIGN_FIXED_USER },
                { "DESKTOP_ASSIGN_USERS_OR_GROUPS", DESKTOP_ASSIGN_USERS_OR_GROUPS },
                { "FIXED_RELATION", FIXED_RELATION },
            };

            private string _value;

            public PriorityStrategyEnum()
            {

            }

            public PriorityStrategyEnum(string value)
            {
                _value = value;
            }

            public static PriorityStrategyEnum FromValue(string value)
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

                if (this.Equals(obj as PriorityStrategyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PriorityStrategyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PriorityStrategyEnum a, PriorityStrategyEnum b)
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

            public static bool operator !=(PriorityStrategyEnum a, PriorityStrategyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 分配的维度，当前支持  - USER: “用户为维度” - DESKTOP:“桌面为维度”两种。
        /// </summary>
        [JsonProperty("assign_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public AssignDimensionEnum AssignDimension { get; set; }
        /// <summary>
        /// 优先分配的策略，策略名为规则为{维度}_{子策略}  - USER_NO_DESKTOP:  用户维度-无桌面 - USER_FIXED_DESKTOP_NUM: 用户维度-桌面个数固定 - DESKTOP_ASSIGN_USER_PRIORITY： 桌面维度-用户优先 - DESKTOP_ASSIGN_FIXED_USER： 桌面维度-固定用户 - DESKTOP_ASSIGN_USERS_OR_GROUPS： 桌面维度-为每台桌面分配所选的所有用户（组） - FIXED_RELATION: 使用参数中的固定分配关系
        /// </summary>
        [JsonProperty("priority_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public PriorityStrategyEnum PriorityStrategy { get; set; }
        /// <summary>
        /// 每个桌面自动分配的用户数，当子策略为 DESKTOP_ASSIGN_FIXED_USER 必填。
        /// </summary>
        [JsonProperty("desktop_assigin_user_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopAssiginUserNum { get; set; }

        /// <summary>
        /// 每个用户自动分配桌面数，当子策略为 USER_NO_DESKTOP、USER_FIXED_DESKTOP_NUM必填。
        /// </summary>
        [JsonProperty("user_assigin_desktop_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserAssiginDesktopNum { get; set; }

        /// <summary>
        /// 策略id，用于指定生成桌面名称策略，如果指定了桌面名称则优先使用指定的桌面名称。
        /// </summary>
        [JsonProperty("desktop_name_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignModelInfo {\n");
            sb.Append("  assignDimension: ").Append(AssignDimension).Append("\n");
            sb.Append("  priorityStrategy: ").Append(PriorityStrategy).Append("\n");
            sb.Append("  desktopAssiginUserNum: ").Append(DesktopAssiginUserNum).Append("\n");
            sb.Append("  userAssiginDesktopNum: ").Append(UserAssiginDesktopNum).Append("\n");
            sb.Append("  desktopNamePolicyId: ").Append(DesktopNamePolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssignModelInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssignModelInfo input)
        {
            if (input == null) return false;
            if (this.AssignDimension != input.AssignDimension) return false;
            if (this.PriorityStrategy != input.PriorityStrategy) return false;
            if (this.DesktopAssiginUserNum != input.DesktopAssiginUserNum || (this.DesktopAssiginUserNum != null && !this.DesktopAssiginUserNum.Equals(input.DesktopAssiginUserNum))) return false;
            if (this.UserAssiginDesktopNum != input.UserAssiginDesktopNum || (this.UserAssiginDesktopNum != null && !this.UserAssiginDesktopNum.Equals(input.UserAssiginDesktopNum))) return false;
            if (this.DesktopNamePolicyId != input.DesktopNamePolicyId || (this.DesktopNamePolicyId != null && !this.DesktopNamePolicyId.Equals(input.DesktopNamePolicyId))) return false;

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
                hashCode = hashCode * 59 + this.AssignDimension.GetHashCode();
                hashCode = hashCode * 59 + this.PriorityStrategy.GetHashCode();
                if (this.DesktopAssiginUserNum != null) hashCode = hashCode * 59 + this.DesktopAssiginUserNum.GetHashCode();
                if (this.UserAssiginDesktopNum != null) hashCode = hashCode * 59 + this.UserAssiginDesktopNum.GetHashCode();
                if (this.DesktopNamePolicyId != null) hashCode = hashCode * 59 + this.DesktopNamePolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
