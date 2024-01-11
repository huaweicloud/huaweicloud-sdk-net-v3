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
    /// 测试连接、预检查、启动、暂停、续传、重置、对比、结束等操作任务请求体。
    /// </summary>
    public class ActionReq 
    {
        /// <summary>
        /// 操作任务动作名称。取值： - network：测试连接源库/目标库。 - precheck：执行预检查。 - start：启动任务。 - stop：暂停任务。 - restart：重试任务。 - reset：重置任务。 - terminate：结束任务。 - skip_precheck：跳过预检查。 - create_compare：创建对比任务。 - cancel_compare：取消对比任务。 - column_limit：字段过滤。 - reload_parameters：重新加载任务参数。
        /// </summary>
        /// <value>操作任务动作名称。取值： - network：测试连接源库/目标库。 - precheck：执行预检查。 - start：启动任务。 - stop：暂停任务。 - restart：重试任务。 - reset：重置任务。 - terminate：结束任务。 - skip_precheck：跳过预检查。 - create_compare：创建对比任务。 - cancel_compare：取消对比任务。 - column_limit：字段过滤。 - reload_parameters：重新加载任务参数。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionNameEnum>))]
        public class ActionNameEnum
        {
            /// <summary>
            /// Enum NETWORK for value: network
            /// </summary>
            public static readonly ActionNameEnum NETWORK = new ActionNameEnum("network");

            /// <summary>
            /// Enum PRECHECK for value: precheck
            /// </summary>
            public static readonly ActionNameEnum PRECHECK = new ActionNameEnum("precheck");

            /// <summary>
            /// Enum START for value: start
            /// </summary>
            public static readonly ActionNameEnum START = new ActionNameEnum("start");

            /// <summary>
            /// Enum STOP for value: stop
            /// </summary>
            public static readonly ActionNameEnum STOP = new ActionNameEnum("stop");

            /// <summary>
            /// Enum RESTART for value: restart
            /// </summary>
            public static readonly ActionNameEnum RESTART = new ActionNameEnum("restart");

            /// <summary>
            /// Enum RESET for value: reset
            /// </summary>
            public static readonly ActionNameEnum RESET = new ActionNameEnum("reset");

            /// <summary>
            /// Enum TERMINATE for value: terminate
            /// </summary>
            public static readonly ActionNameEnum TERMINATE = new ActionNameEnum("terminate");

            /// <summary>
            /// Enum SKIP_PRECHECK for value: skip_precheck
            /// </summary>
            public static readonly ActionNameEnum SKIP_PRECHECK = new ActionNameEnum("skip_precheck");

            /// <summary>
            /// Enum CREATE_COMPARE for value: create_compare
            /// </summary>
            public static readonly ActionNameEnum CREATE_COMPARE = new ActionNameEnum("create_compare");

            /// <summary>
            /// Enum CANCEL_COMPARE for value: cancel_compare
            /// </summary>
            public static readonly ActionNameEnum CANCEL_COMPARE = new ActionNameEnum("cancel_compare");

            /// <summary>
            /// Enum COLUMN_LIMIT for value: column_limit
            /// </summary>
            public static readonly ActionNameEnum COLUMN_LIMIT = new ActionNameEnum("column_limit");

            /// <summary>
            /// Enum RELOAD_PARAMETERS for value: reload_parameters
            /// </summary>
            public static readonly ActionNameEnum RELOAD_PARAMETERS = new ActionNameEnum("reload_parameters");

            private static readonly Dictionary<string, ActionNameEnum> StaticFields =
            new Dictionary<string, ActionNameEnum>()
            {
                { "network", NETWORK },
                { "precheck", PRECHECK },
                { "start", START },
                { "stop", STOP },
                { "restart", RESTART },
                { "reset", RESET },
                { "terminate", TERMINATE },
                { "skip_precheck", SKIP_PRECHECK },
                { "create_compare", CREATE_COMPARE },
                { "cancel_compare", CANCEL_COMPARE },
                { "column_limit", COLUMN_LIMIT },
                { "reload_parameters", RELOAD_PARAMETERS },
            };

            private string _value;

            public ActionNameEnum()
            {

            }

            public ActionNameEnum(string value)
            {
                _value = value;
            }

            public static ActionNameEnum FromValue(string value)
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

                if (this.Equals(obj as ActionNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionNameEnum a, ActionNameEnum b)
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

            public static bool operator !=(ActionNameEnum a, ActionNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID (对比任务相关操作，多任务场景传父任务详情返回的master_job_id)，批量操作时必填
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 操作任务动作名称。取值： - network：测试连接源库/目标库。 - precheck：执行预检查。 - start：启动任务。 - stop：暂停任务。 - restart：重试任务。 - reset：重置任务。 - terminate：结束任务。 - skip_precheck：跳过预检查。 - create_compare：创建对比任务。 - cancel_compare：取消对比任务。 - column_limit：字段过滤。 - reload_parameters：重新加载任务参数。
        /// </summary>
        [JsonProperty("action_name", NullValueHandling = NullValueHandling.Ignore)]
        public ActionNameEnum ActionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("action_params", NullValueHandling = NullValueHandling.Ignore)]
        public ActionParams ActionParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  actionName: ").Append(ActionName).Append("\n");
            sb.Append("  actionParams: ").Append(ActionParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionReq input)
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
                    this.ActionName == input.ActionName ||
                    (this.ActionName != null &&
                    this.ActionName.Equals(input.ActionName))
                ) && 
                (
                    this.ActionParams == input.ActionParams ||
                    (this.ActionParams != null &&
                    this.ActionParams.Equals(input.ActionParams))
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
                if (this.ActionName != null)
                    hashCode = hashCode * 59 + this.ActionName.GetHashCode();
                if (this.ActionParams != null)
                    hashCode = hashCode * 59 + this.ActionParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
