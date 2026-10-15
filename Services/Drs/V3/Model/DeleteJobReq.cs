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
    /// 删除在线迁移任务请求体。
    /// </summary>
    public class DeleteJobReq 
    {
        /// <summary>
        /// **参数解释**：  批量结束或删除任务的操作类型，指定对任务执行结束还是删除操作。  **约束限制**：  包年/包月任务需要先手动退订，然后delete_type参数设置为delete调用该接口删除任务。  **取值范围**：  - terminate：结束任务 - force_terminate：强制结束任务 - delete：删除任务 - roll_back_upgrade_active_standby：转主备任务回滚  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  批量结束或删除任务的操作类型，指定对任务执行结束还是删除操作。  **约束限制**：  包年/包月任务需要先手动退订，然后delete_type参数设置为delete调用该接口删除任务。  **取值范围**：  - terminate：结束任务 - force_terminate：强制结束任务 - delete：删除任务 - roll_back_upgrade_active_standby：转主备任务回滚  **默认取值**：  不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteTypeEnum>))]
        public class DeleteTypeEnum
        {
            /// <summary>
            /// Enum TERMINATE for value: terminate
            /// </summary>
            public static readonly DeleteTypeEnum TERMINATE = new DeleteTypeEnum("terminate");

            /// <summary>
            /// Enum FORCE_TERMINATE for value: force_terminate
            /// </summary>
            public static readonly DeleteTypeEnum FORCE_TERMINATE = new DeleteTypeEnum("force_terminate");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly DeleteTypeEnum DELETE = new DeleteTypeEnum("delete");

            /// <summary>
            /// Enum ROLL_BACK_UPGRADE_ACTIVE_STANDBY for value: roll_back_upgrade_active_standby
            /// </summary>
            public static readonly DeleteTypeEnum ROLL_BACK_UPGRADE_ACTIVE_STANDBY = new DeleteTypeEnum("roll_back_upgrade_active_standby");

            private static readonly Dictionary<string, DeleteTypeEnum> StaticFields =
            new Dictionary<string, DeleteTypeEnum>()
            {
                { "terminate", TERMINATE },
                { "force_terminate", FORCE_TERMINATE },
                { "delete", DELETE },
                { "roll_back_upgrade_active_standby", ROLL_BACK_UPGRADE_ACTIVE_STANDBY },
            };

            private string _value;

            public DeleteTypeEnum()
            {

            }

            public DeleteTypeEnum(string value)
            {
                _value = value;
            }

            public static DeleteTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteTypeEnum a, DeleteTypeEnum b)
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

            public static bool operator !=(DeleteTypeEnum a, DeleteTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  批量结束或删除任务的操作类型，指定对任务执行结束还是删除操作。  **约束限制**：  包年/包月任务需要先手动退订，然后delete_type参数设置为delete调用该接口删除任务。  **取值范围**：  - terminate：结束任务 - force_terminate：强制结束任务 - delete：删除任务 - roll_back_upgrade_active_standby：转主备任务回滚  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("delete_type", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteTypeEnum DeleteType { get; set; }
        /// <summary>
        /// **参数解释**：  任务ID，用于唯一标识需要结束或删除的数据复制任务。  **约束限制**：  不涉及。  **取值范围**：  UUID格式字符串。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：  MySQL为源的数据复制任务，结束任务时是否展示断点信息。  **约束限制**：  仅MySQL为源的实时迁移、实时同步、实时灾备任务适用。  **取值范围**：  - true：展示断点信息 - false：不展示断点信息  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("is_show_breakpoint_position", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShowBreakpointPosition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteJobReq {\n");
            sb.Append("  deleteType: ").Append(DeleteType).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isShowBreakpointPosition: ").Append(IsShowBreakpointPosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteJobReq input)
        {
            if (input == null) return false;
            if (this.DeleteType != input.DeleteType) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.IsShowBreakpointPosition != input.IsShowBreakpointPosition || (this.IsShowBreakpointPosition != null && !this.IsShowBreakpointPosition.Equals(input.IsShowBreakpointPosition))) return false;

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
                hashCode = hashCode * 59 + this.DeleteType.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsShowBreakpointPosition != null) hashCode = hashCode * 59 + this.IsShowBreakpointPosition.GetHashCode();
                return hashCode;
            }
        }
    }
}
