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
    /// 任务操作命令集合。
    /// </summary>
    public class JobActions 
    {
        /// <summary>
        /// 任务当前操作命令。取值： - API_CONFIGURATION_ACTION：OPEN API配置中的任务能调用。 - CHANGE：修改任务。 - CHANGE_MODE：修改任务模式。 - CHOOSE_OBJECT：选择对象。 - CLONE：克隆任务。 - CONTINUE_APPLY：启动回放，Oracle同步到GaussDB分布式适用。 - CONTINUE_CAPTURE：启动抓取，Oracle同步到GaussDB分布式适用。 - CONTINUE_JOB：启动失败或者停止的任务，Oracle同步到GaussDB分布式适用。 - CREATE：创建任务。 - DELETE：删除任务。 - FREE_RESOURCE：释放资源。 - JUMP_RETRY：跳跃续传任务。 - MODIFY_CONFIGURATION：修改任务配置。 - MODIFY_DB_CONFIG：修改数据库配置。 - MODIFY_TASK_NUMBER：修改线程数配置。 - NODE_FLAVOR_MODIFY：规格变更。 - ORDER_INFO：订单详情。 - PAUSE：暂停任务。 - PAY_ORDER：包年/包月支付订单。 - PRE_CHECK：预检查。 - QUERY_PRE_CHECK：查询预检查结果。 - RESET：重置任务。 - RESET_DB_PWD：重置数据库密码（源库、目标库）。 - RETRY：重试任务。 - START：启动任务。 - START_INCR：启动增量任务。 - STOP_APPLY：停止回放，Oracle同步到GaussDB分布式适用。 - STOP_CAPTURE：停止抓取，Oracle同步到GaussDB分布式适用。 - STOP_JOB：停止任务，Oracle同步到GaussDB分布式适用。 - SWITCH_OVER：灾备倒换。 - TO_PERIOD：转包年/包月任务。 - TO_RENEW：包年/包月任务续费。 - UNSUBSCRIBE：包年/包月任务退订。
        /// </summary>
        /// <value>任务当前操作命令。取值： - API_CONFIGURATION_ACTION：OPEN API配置中的任务能调用。 - CHANGE：修改任务。 - CHANGE_MODE：修改任务模式。 - CHOOSE_OBJECT：选择对象。 - CLONE：克隆任务。 - CONTINUE_APPLY：启动回放，Oracle同步到GaussDB分布式适用。 - CONTINUE_CAPTURE：启动抓取，Oracle同步到GaussDB分布式适用。 - CONTINUE_JOB：启动失败或者停止的任务，Oracle同步到GaussDB分布式适用。 - CREATE：创建任务。 - DELETE：删除任务。 - FREE_RESOURCE：释放资源。 - JUMP_RETRY：跳跃续传任务。 - MODIFY_CONFIGURATION：修改任务配置。 - MODIFY_DB_CONFIG：修改数据库配置。 - MODIFY_TASK_NUMBER：修改线程数配置。 - NODE_FLAVOR_MODIFY：规格变更。 - ORDER_INFO：订单详情。 - PAUSE：暂停任务。 - PAY_ORDER：包年/包月支付订单。 - PRE_CHECK：预检查。 - QUERY_PRE_CHECK：查询预检查结果。 - RESET：重置任务。 - RESET_DB_PWD：重置数据库密码（源库、目标库）。 - RETRY：重试任务。 - START：启动任务。 - START_INCR：启动增量任务。 - STOP_APPLY：停止回放，Oracle同步到GaussDB分布式适用。 - STOP_CAPTURE：停止抓取，Oracle同步到GaussDB分布式适用。 - STOP_JOB：停止任务，Oracle同步到GaussDB分布式适用。 - SWITCH_OVER：灾备倒换。 - TO_PERIOD：转包年/包月任务。 - TO_RENEW：包年/包月任务续费。 - UNSUBSCRIBE：包年/包月任务退订。</value>
        [JsonConverter(typeof(EnumClassConverter<CurrentActionEnum>))]
        public class CurrentActionEnum
        {
            /// <summary>
            /// Enum API_CONFIGURATION_ACTION for value: API_CONFIGURATION_ACTION
            /// </summary>
            public static readonly CurrentActionEnum API_CONFIGURATION_ACTION = new CurrentActionEnum("API_CONFIGURATION_ACTION");

            /// <summary>
            /// Enum CHANGE for value: CHANGE
            /// </summary>
            public static readonly CurrentActionEnum CHANGE = new CurrentActionEnum("CHANGE");

            /// <summary>
            /// Enum CHANGE_MODE for value: CHANGE_MODE
            /// </summary>
            public static readonly CurrentActionEnum CHANGE_MODE = new CurrentActionEnum("CHANGE_MODE");

            /// <summary>
            /// Enum CHOOSE_OBJECT for value: CHOOSE_OBJECT
            /// </summary>
            public static readonly CurrentActionEnum CHOOSE_OBJECT = new CurrentActionEnum("CHOOSE_OBJECT");

            /// <summary>
            /// Enum CLONE for value: CLONE
            /// </summary>
            public static readonly CurrentActionEnum CLONE = new CurrentActionEnum("CLONE");

            /// <summary>
            /// Enum CONTINUE_APPLY for value: CONTINUE_APPLY
            /// </summary>
            public static readonly CurrentActionEnum CONTINUE_APPLY = new CurrentActionEnum("CONTINUE_APPLY");

            /// <summary>
            /// Enum CONTINUE_CAPTURE for value: CONTINUE_CAPTURE
            /// </summary>
            public static readonly CurrentActionEnum CONTINUE_CAPTURE = new CurrentActionEnum("CONTINUE_CAPTURE");

            /// <summary>
            /// Enum CONTINUE_JOB for value: CONTINUE_JOB
            /// </summary>
            public static readonly CurrentActionEnum CONTINUE_JOB = new CurrentActionEnum("CONTINUE_JOB");

            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly CurrentActionEnum CREATE = new CurrentActionEnum("CREATE");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly CurrentActionEnum DELETE = new CurrentActionEnum("DELETE");

            /// <summary>
            /// Enum FREE_RESOURCE for value: FREE_RESOURCE
            /// </summary>
            public static readonly CurrentActionEnum FREE_RESOURCE = new CurrentActionEnum("FREE_RESOURCE");

            /// <summary>
            /// Enum JUMP_RETRY for value: JUMP_RETRY
            /// </summary>
            public static readonly CurrentActionEnum JUMP_RETRY = new CurrentActionEnum("JUMP_RETRY");

            /// <summary>
            /// Enum MODIFY_CONFIGURATION for value: MODIFY_CONFIGURATION
            /// </summary>
            public static readonly CurrentActionEnum MODIFY_CONFIGURATION = new CurrentActionEnum("MODIFY_CONFIGURATION");

            /// <summary>
            /// Enum MODIFY_DB_CONFIG for value: MODIFY_DB_CONFIG
            /// </summary>
            public static readonly CurrentActionEnum MODIFY_DB_CONFIG = new CurrentActionEnum("MODIFY_DB_CONFIG");

            /// <summary>
            /// Enum MODIFY_TASK_NUMBER for value: MODIFY_TASK_NUMBER
            /// </summary>
            public static readonly CurrentActionEnum MODIFY_TASK_NUMBER = new CurrentActionEnum("MODIFY_TASK_NUMBER");

            /// <summary>
            /// Enum NODE_FLAVOR_MODIFY for value: NODE_FLAVOR_MODIFY
            /// </summary>
            public static readonly CurrentActionEnum NODE_FLAVOR_MODIFY = new CurrentActionEnum("NODE_FLAVOR_MODIFY");

            /// <summary>
            /// Enum ORDER_INFO for value: ORDER_INFO
            /// </summary>
            public static readonly CurrentActionEnum ORDER_INFO = new CurrentActionEnum("ORDER_INFO");

            /// <summary>
            /// Enum PAUSE for value: PAUSE
            /// </summary>
            public static readonly CurrentActionEnum PAUSE = new CurrentActionEnum("PAUSE");

            /// <summary>
            /// Enum PAY_ORDER for value: PAY_ORDER
            /// </summary>
            public static readonly CurrentActionEnum PAY_ORDER = new CurrentActionEnum("PAY_ORDER");

            /// <summary>
            /// Enum PRE_CHECK for value: PRE_CHECK
            /// </summary>
            public static readonly CurrentActionEnum PRE_CHECK = new CurrentActionEnum("PRE_CHECK");

            /// <summary>
            /// Enum QUERY_PRE_CHECK for value: QUERY_PRE_CHECK
            /// </summary>
            public static readonly CurrentActionEnum QUERY_PRE_CHECK = new CurrentActionEnum("QUERY_PRE_CHECK");

            /// <summary>
            /// Enum RESET for value: RESET
            /// </summary>
            public static readonly CurrentActionEnum RESET = new CurrentActionEnum("RESET");

            /// <summary>
            /// Enum RESET_DB_PWD for value: RESET_DB_PWD
            /// </summary>
            public static readonly CurrentActionEnum RESET_DB_PWD = new CurrentActionEnum("RESET_DB_PWD");

            /// <summary>
            /// Enum RETRY for value: RETRY
            /// </summary>
            public static readonly CurrentActionEnum RETRY = new CurrentActionEnum("RETRY");

            /// <summary>
            /// Enum START for value: START
            /// </summary>
            public static readonly CurrentActionEnum START = new CurrentActionEnum("START");

            /// <summary>
            /// Enum START_INCR for value: START_INCR
            /// </summary>
            public static readonly CurrentActionEnum START_INCR = new CurrentActionEnum("START_INCR");

            /// <summary>
            /// Enum STOP_APPLY for value: STOP_APPLY
            /// </summary>
            public static readonly CurrentActionEnum STOP_APPLY = new CurrentActionEnum("STOP_APPLY");

            /// <summary>
            /// Enum STOP_CAPTURE for value: STOP_CAPTURE
            /// </summary>
            public static readonly CurrentActionEnum STOP_CAPTURE = new CurrentActionEnum("STOP_CAPTURE");

            /// <summary>
            /// Enum STOP_JOB for value: STOP_JOB
            /// </summary>
            public static readonly CurrentActionEnum STOP_JOB = new CurrentActionEnum("STOP_JOB");

            /// <summary>
            /// Enum SWITCH_OVER for value: SWITCH_OVER
            /// </summary>
            public static readonly CurrentActionEnum SWITCH_OVER = new CurrentActionEnum("SWITCH_OVER");

            /// <summary>
            /// Enum TO_PERIOD for value: TO_PERIOD
            /// </summary>
            public static readonly CurrentActionEnum TO_PERIOD = new CurrentActionEnum("TO_PERIOD");

            /// <summary>
            /// Enum TO_RENEW for value: TO_RENEW
            /// </summary>
            public static readonly CurrentActionEnum TO_RENEW = new CurrentActionEnum("TO_RENEW");

            /// <summary>
            /// Enum UNSUBSCRIBE for value: UNSUBSCRIBE
            /// </summary>
            public static readonly CurrentActionEnum UNSUBSCRIBE = new CurrentActionEnum("UNSUBSCRIBE");

            private static readonly Dictionary<string, CurrentActionEnum> StaticFields =
            new Dictionary<string, CurrentActionEnum>()
            {
                { "API_CONFIGURATION_ACTION", API_CONFIGURATION_ACTION },
                { "CHANGE", CHANGE },
                { "CHANGE_MODE", CHANGE_MODE },
                { "CHOOSE_OBJECT", CHOOSE_OBJECT },
                { "CLONE", CLONE },
                { "CONTINUE_APPLY", CONTINUE_APPLY },
                { "CONTINUE_CAPTURE", CONTINUE_CAPTURE },
                { "CONTINUE_JOB", CONTINUE_JOB },
                { "CREATE", CREATE },
                { "DELETE", DELETE },
                { "FREE_RESOURCE", FREE_RESOURCE },
                { "JUMP_RETRY", JUMP_RETRY },
                { "MODIFY_CONFIGURATION", MODIFY_CONFIGURATION },
                { "MODIFY_DB_CONFIG", MODIFY_DB_CONFIG },
                { "MODIFY_TASK_NUMBER", MODIFY_TASK_NUMBER },
                { "NODE_FLAVOR_MODIFY", NODE_FLAVOR_MODIFY },
                { "ORDER_INFO", ORDER_INFO },
                { "PAUSE", PAUSE },
                { "PAY_ORDER", PAY_ORDER },
                { "PRE_CHECK", PRE_CHECK },
                { "QUERY_PRE_CHECK", QUERY_PRE_CHECK },
                { "RESET", RESET },
                { "RESET_DB_PWD", RESET_DB_PWD },
                { "RETRY", RETRY },
                { "START", START },
                { "START_INCR", START_INCR },
                { "STOP_APPLY", STOP_APPLY },
                { "STOP_CAPTURE", STOP_CAPTURE },
                { "STOP_JOB", STOP_JOB },
                { "SWITCH_OVER", SWITCH_OVER },
                { "TO_PERIOD", TO_PERIOD },
                { "TO_RENEW", TO_RENEW },
                { "UNSUBSCRIBE", UNSUBSCRIBE },
            };

            private string _value;

            public CurrentActionEnum()
            {

            }

            public CurrentActionEnum(string value)
            {
                _value = value;
            }

            public static CurrentActionEnum FromValue(string value)
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

                if (this.Equals(obj as CurrentActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CurrentActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CurrentActionEnum a, CurrentActionEnum b)
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

            public static bool operator !=(CurrentActionEnum a, CurrentActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务可操作命令集合。
        /// </summary>
        [JsonProperty("available_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableActions { get; set; }

        /// <summary>
        /// 任务不可操作命令集合。
        /// </summary>
        [JsonProperty("unavailable_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableActions { get; set; }

        /// <summary>
        /// 任务当前操作命令。取值： - API_CONFIGURATION_ACTION：OPEN API配置中的任务能调用。 - CHANGE：修改任务。 - CHANGE_MODE：修改任务模式。 - CHOOSE_OBJECT：选择对象。 - CLONE：克隆任务。 - CONTINUE_APPLY：启动回放，Oracle同步到GaussDB分布式适用。 - CONTINUE_CAPTURE：启动抓取，Oracle同步到GaussDB分布式适用。 - CONTINUE_JOB：启动失败或者停止的任务，Oracle同步到GaussDB分布式适用。 - CREATE：创建任务。 - DELETE：删除任务。 - FREE_RESOURCE：释放资源。 - JUMP_RETRY：跳跃续传任务。 - MODIFY_CONFIGURATION：修改任务配置。 - MODIFY_DB_CONFIG：修改数据库配置。 - MODIFY_TASK_NUMBER：修改线程数配置。 - NODE_FLAVOR_MODIFY：规格变更。 - ORDER_INFO：订单详情。 - PAUSE：暂停任务。 - PAY_ORDER：包年/包月支付订单。 - PRE_CHECK：预检查。 - QUERY_PRE_CHECK：查询预检查结果。 - RESET：重置任务。 - RESET_DB_PWD：重置数据库密码（源库、目标库）。 - RETRY：重试任务。 - START：启动任务。 - START_INCR：启动增量任务。 - STOP_APPLY：停止回放，Oracle同步到GaussDB分布式适用。 - STOP_CAPTURE：停止抓取，Oracle同步到GaussDB分布式适用。 - STOP_JOB：停止任务，Oracle同步到GaussDB分布式适用。 - SWITCH_OVER：灾备倒换。 - TO_PERIOD：转包年/包月任务。 - TO_RENEW：包年/包月任务续费。 - UNSUBSCRIBE：包年/包月任务退订。
        /// </summary>
        [JsonProperty("current_action", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentActionEnum CurrentAction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobActions {\n");
            sb.Append("  availableActions: ").Append(AvailableActions).Append("\n");
            sb.Append("  unavailableActions: ").Append(UnavailableActions).Append("\n");
            sb.Append("  currentAction: ").Append(CurrentAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobActions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableActions == input.AvailableActions ||
                    this.AvailableActions != null &&
                    input.AvailableActions != null &&
                    this.AvailableActions.SequenceEqual(input.AvailableActions)
                ) && 
                (
                    this.UnavailableActions == input.UnavailableActions ||
                    this.UnavailableActions != null &&
                    input.UnavailableActions != null &&
                    this.UnavailableActions.SequenceEqual(input.UnavailableActions)
                ) && 
                (
                    this.CurrentAction == input.CurrentAction ||
                    (this.CurrentAction != null &&
                    this.CurrentAction.Equals(input.CurrentAction))
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
                if (this.AvailableActions != null)
                    hashCode = hashCode * 59 + this.AvailableActions.GetHashCode();
                if (this.UnavailableActions != null)
                    hashCode = hashCode * 59 + this.UnavailableActions.GetHashCode();
                if (this.CurrentAction != null)
                    hashCode = hashCode * 59 + this.CurrentAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
