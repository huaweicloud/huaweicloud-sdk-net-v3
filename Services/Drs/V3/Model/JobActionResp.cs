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
    /// 
    /// </summary>
    public class JobActionResp 
    {
        /// <summary>
        /// Defines availableActions
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AvailableActionsEnum>))]
        public class AvailableActionsEnum
        {
            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly AvailableActionsEnum CREATE = new AvailableActionsEnum("CREATE");

            /// <summary>
            /// Enum CHOOSE_OBJECT for value: CHOOSE_OBJECT
            /// </summary>
            public static readonly AvailableActionsEnum CHOOSE_OBJECT = new AvailableActionsEnum("CHOOSE_OBJECT");

            /// <summary>
            /// Enum PRE_CHECK for value: PRE_CHECK
            /// </summary>
            public static readonly AvailableActionsEnum PRE_CHECK = new AvailableActionsEnum("PRE_CHECK");

            /// <summary>
            /// Enum CHANGE_MODE for value: CHANGE_MODE
            /// </summary>
            public static readonly AvailableActionsEnum CHANGE_MODE = new AvailableActionsEnum("CHANGE_MODE");

            /// <summary>
            /// Enum FREE_RESOURCE for value: FREE_RESOURCE
            /// </summary>
            public static readonly AvailableActionsEnum FREE_RESOURCE = new AvailableActionsEnum("FREE_RESOURCE");

            /// <summary>
            /// Enum MODIFY_DB_CONFIG for value: MODIFY_DB_CONFIG
            /// </summary>
            public static readonly AvailableActionsEnum MODIFY_DB_CONFIG = new AvailableActionsEnum("MODIFY_DB_CONFIG");

            /// <summary>
            /// Enum RESET_DB_PWD for value: RESET_DB_PWD
            /// </summary>
            public static readonly AvailableActionsEnum RESET_DB_PWD = new AvailableActionsEnum("RESET_DB_PWD");

            /// <summary>
            /// Enum MODIFY_CONFIGURATION for value: MODIFY_CONFIGURATION
            /// </summary>
            public static readonly AvailableActionsEnum MODIFY_CONFIGURATION = new AvailableActionsEnum("MODIFY_CONFIGURATION");

            /// <summary>
            /// Enum PAUSE for value: PAUSE
            /// </summary>
            public static readonly AvailableActionsEnum PAUSE = new AvailableActionsEnum("PAUSE");

            /// <summary>
            /// Enum START for value: START
            /// </summary>
            public static readonly AvailableActionsEnum START = new AvailableActionsEnum("START");

            /// <summary>
            /// Enum CHANGE for value: CHANGE
            /// </summary>
            public static readonly AvailableActionsEnum CHANGE = new AvailableActionsEnum("CHANGE");

            /// <summary>
            /// Enum RETRY for value: RETRY
            /// </summary>
            public static readonly AvailableActionsEnum RETRY = new AvailableActionsEnum("RETRY");

            /// <summary>
            /// Enum RESET for value: RESET
            /// </summary>
            public static readonly AvailableActionsEnum RESET = new AvailableActionsEnum("RESET");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly AvailableActionsEnum DELETE = new AvailableActionsEnum("DELETE");

            /// <summary>
            /// Enum QUERY_PRE_CHECK for value: QUERY_PRE_CHECK
            /// </summary>
            public static readonly AvailableActionsEnum QUERY_PRE_CHECK = new AvailableActionsEnum("QUERY_PRE_CHECK");

            /// <summary>
            /// Enum SWITCH_OVER for value: SWITCH_OVER
            /// </summary>
            public static readonly AvailableActionsEnum SWITCH_OVER = new AvailableActionsEnum("SWITCH_OVER");

            /// <summary>
            /// Enum MODIFY_SPECIFICATION_ID for value: MODIFY_SPECIFICATION_ID
            /// </summary>
            public static readonly AvailableActionsEnum MODIFY_SPECIFICATION_ID = new AvailableActionsEnum("MODIFY_SPECIFICATION_ID");

            /// <summary>
            /// Enum JUMP_RETRY for value: JUMP_RETRY
            /// </summary>
            public static readonly AvailableActionsEnum JUMP_RETRY = new AvailableActionsEnum("JUMP_RETRY");

            /// <summary>
            /// Enum START_INCR for value: START_INCR
            /// </summary>
            public static readonly AvailableActionsEnum START_INCR = new AvailableActionsEnum("START_INCR");

            /// <summary>
            /// Enum MODIFY_TASK_NUMBER for value: MODIFY_TASK_NUMBER
            /// </summary>
            public static readonly AvailableActionsEnum MODIFY_TASK_NUMBER = new AvailableActionsEnum("MODIFY_TASK_NUMBER");

            /// <summary>
            /// Enum CONTINUE_JOB for value: CONTINUE_JOB
            /// </summary>
            public static readonly AvailableActionsEnum CONTINUE_JOB = new AvailableActionsEnum("CONTINUE_JOB");

            /// <summary>
            /// Enum STOP_JOB for value: STOP_JOB
            /// </summary>
            public static readonly AvailableActionsEnum STOP_JOB = new AvailableActionsEnum("STOP_JOB");

            /// <summary>
            /// Enum CONTINUE_CAPTURE for value: CONTINUE_CAPTURE
            /// </summary>
            public static readonly AvailableActionsEnum CONTINUE_CAPTURE = new AvailableActionsEnum("CONTINUE_CAPTURE");

            /// <summary>
            /// Enum STOP_CAPTURE for value: STOP_CAPTURE
            /// </summary>
            public static readonly AvailableActionsEnum STOP_CAPTURE = new AvailableActionsEnum("STOP_CAPTURE");

            /// <summary>
            /// Enum CONTINUE_APPLY for value: CONTINUE_APPLY
            /// </summary>
            public static readonly AvailableActionsEnum CONTINUE_APPLY = new AvailableActionsEnum("CONTINUE_APPLY");

            /// <summary>
            /// Enum API_CONFIGURATION_ACTION for value: API_CONFIGURATION_ACTION
            /// </summary>
            public static readonly AvailableActionsEnum API_CONFIGURATION_ACTION = new AvailableActionsEnum("API_CONFIGURATION_ACTION");

            /// <summary>
            /// Enum STOP_APPLY for value: STOP_APPLY
            /// </summary>
            public static readonly AvailableActionsEnum STOP_APPLY = new AvailableActionsEnum("STOP_APPLY");

            /// <summary>
            /// Enum PAY_ORDER for value: PAY_ORDER
            /// </summary>
            public static readonly AvailableActionsEnum PAY_ORDER = new AvailableActionsEnum("PAY_ORDER");

            /// <summary>
            /// Enum UNSUBSCRIBE for value: UNSUBSCRIBE
            /// </summary>
            public static readonly AvailableActionsEnum UNSUBSCRIBE = new AvailableActionsEnum("UNSUBSCRIBE");

            /// <summary>
            /// Enum TO_PERIOD for value: TO_PERIOD
            /// </summary>
            public static readonly AvailableActionsEnum TO_PERIOD = new AvailableActionsEnum("TO_PERIOD");

            /// <summary>
            /// Enum TO_RENEW for value: TO_RENEW
            /// </summary>
            public static readonly AvailableActionsEnum TO_RENEW = new AvailableActionsEnum("TO_RENEW");

            /// <summary>
            /// Enum ORDER_INFO for value: ORDER_INFO
            /// </summary>
            public static readonly AvailableActionsEnum ORDER_INFO = new AvailableActionsEnum("ORDER_INFO");

            /// <summary>
            /// Enum CHANGE_FLAVOR for value: CHANGE_FLAVOR
            /// </summary>
            public static readonly AvailableActionsEnum CHANGE_FLAVOR = new AvailableActionsEnum("CHANGE_FLAVOR");

            /// <summary>
            /// Enum CLONE for value: CLONE
            /// </summary>
            public static readonly AvailableActionsEnum CLONE = new AvailableActionsEnum("CLONE");

            private static readonly Dictionary<string, AvailableActionsEnum> StaticFields =
            new Dictionary<string, AvailableActionsEnum>()
            {
                { "CREATE", CREATE },
                { "CHOOSE_OBJECT", CHOOSE_OBJECT },
                { "PRE_CHECK", PRE_CHECK },
                { "CHANGE_MODE", CHANGE_MODE },
                { "FREE_RESOURCE", FREE_RESOURCE },
                { "MODIFY_DB_CONFIG", MODIFY_DB_CONFIG },
                { "RESET_DB_PWD", RESET_DB_PWD },
                { "MODIFY_CONFIGURATION", MODIFY_CONFIGURATION },
                { "PAUSE", PAUSE },
                { "START", START },
                { "CHANGE", CHANGE },
                { "RETRY", RETRY },
                { "RESET", RESET },
                { "DELETE", DELETE },
                { "QUERY_PRE_CHECK", QUERY_PRE_CHECK },
                { "SWITCH_OVER", SWITCH_OVER },
                { "MODIFY_SPECIFICATION_ID", MODIFY_SPECIFICATION_ID },
                { "JUMP_RETRY", JUMP_RETRY },
                { "START_INCR", START_INCR },
                { "MODIFY_TASK_NUMBER", MODIFY_TASK_NUMBER },
                { "CONTINUE_JOB", CONTINUE_JOB },
                { "STOP_JOB", STOP_JOB },
                { "CONTINUE_CAPTURE", CONTINUE_CAPTURE },
                { "STOP_CAPTURE", STOP_CAPTURE },
                { "CONTINUE_APPLY", CONTINUE_APPLY },
                { "API_CONFIGURATION_ACTION", API_CONFIGURATION_ACTION },
                { "STOP_APPLY", STOP_APPLY },
                { "PAY_ORDER", PAY_ORDER },
                { "UNSUBSCRIBE", UNSUBSCRIBE },
                { "TO_PERIOD", TO_PERIOD },
                { "TO_RENEW", TO_RENEW },
                { "ORDER_INFO", ORDER_INFO },
                { "CHANGE_FLAVOR", CHANGE_FLAVOR },
                { "CLONE", CLONE },
            };

            private string _value;

            public AvailableActionsEnum()
            {

            }

            public AvailableActionsEnum(string value)
            {
                _value = value;
            }

            public static AvailableActionsEnum FromValue(string value)
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

                if (this.Equals(obj as AvailableActionsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AvailableActionsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AvailableActionsEnum a, AvailableActionsEnum b)
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

            public static bool operator !=(AvailableActionsEnum a, AvailableActionsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines unavailableActions
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<UnavailableActionsEnum>))]
        public class UnavailableActionsEnum
        {
            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly UnavailableActionsEnum CREATE = new UnavailableActionsEnum("CREATE");

            /// <summary>
            /// Enum CHOOSE_OBJECT for value: CHOOSE_OBJECT
            /// </summary>
            public static readonly UnavailableActionsEnum CHOOSE_OBJECT = new UnavailableActionsEnum("CHOOSE_OBJECT");

            /// <summary>
            /// Enum PRE_CHECK for value: PRE_CHECK
            /// </summary>
            public static readonly UnavailableActionsEnum PRE_CHECK = new UnavailableActionsEnum("PRE_CHECK");

            /// <summary>
            /// Enum CHANGE_MODE for value: CHANGE_MODE
            /// </summary>
            public static readonly UnavailableActionsEnum CHANGE_MODE = new UnavailableActionsEnum("CHANGE_MODE");

            /// <summary>
            /// Enum FREE_RESOURCE for value: FREE_RESOURCE
            /// </summary>
            public static readonly UnavailableActionsEnum FREE_RESOURCE = new UnavailableActionsEnum("FREE_RESOURCE");

            /// <summary>
            /// Enum MODIFY_DB_CONFIG for value: MODIFY_DB_CONFIG
            /// </summary>
            public static readonly UnavailableActionsEnum MODIFY_DB_CONFIG = new UnavailableActionsEnum("MODIFY_DB_CONFIG");

            /// <summary>
            /// Enum RESET_DB_PWD for value: RESET_DB_PWD
            /// </summary>
            public static readonly UnavailableActionsEnum RESET_DB_PWD = new UnavailableActionsEnum("RESET_DB_PWD");

            /// <summary>
            /// Enum MODIFY_CONFIGURATION for value: MODIFY_CONFIGURATION
            /// </summary>
            public static readonly UnavailableActionsEnum MODIFY_CONFIGURATION = new UnavailableActionsEnum("MODIFY_CONFIGURATION");

            /// <summary>
            /// Enum PAUSE for value: PAUSE
            /// </summary>
            public static readonly UnavailableActionsEnum PAUSE = new UnavailableActionsEnum("PAUSE");

            /// <summary>
            /// Enum START for value: START
            /// </summary>
            public static readonly UnavailableActionsEnum START = new UnavailableActionsEnum("START");

            /// <summary>
            /// Enum CHANGE for value: CHANGE
            /// </summary>
            public static readonly UnavailableActionsEnum CHANGE = new UnavailableActionsEnum("CHANGE");

            /// <summary>
            /// Enum RETRY for value: RETRY
            /// </summary>
            public static readonly UnavailableActionsEnum RETRY = new UnavailableActionsEnum("RETRY");

            /// <summary>
            /// Enum RESET for value: RESET
            /// </summary>
            public static readonly UnavailableActionsEnum RESET = new UnavailableActionsEnum("RESET");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly UnavailableActionsEnum DELETE = new UnavailableActionsEnum("DELETE");

            /// <summary>
            /// Enum QUERY_PRE_CHECK for value: QUERY_PRE_CHECK
            /// </summary>
            public static readonly UnavailableActionsEnum QUERY_PRE_CHECK = new UnavailableActionsEnum("QUERY_PRE_CHECK");

            /// <summary>
            /// Enum SWITCH_OVER for value: SWITCH_OVER
            /// </summary>
            public static readonly UnavailableActionsEnum SWITCH_OVER = new UnavailableActionsEnum("SWITCH_OVER");

            /// <summary>
            /// Enum MODIFY_SPECIFICATION_ID for value: MODIFY_SPECIFICATION_ID
            /// </summary>
            public static readonly UnavailableActionsEnum MODIFY_SPECIFICATION_ID = new UnavailableActionsEnum("MODIFY_SPECIFICATION_ID");

            /// <summary>
            /// Enum JUMP_RETRY for value: JUMP_RETRY
            /// </summary>
            public static readonly UnavailableActionsEnum JUMP_RETRY = new UnavailableActionsEnum("JUMP_RETRY");

            /// <summary>
            /// Enum START_INCR for value: START_INCR
            /// </summary>
            public static readonly UnavailableActionsEnum START_INCR = new UnavailableActionsEnum("START_INCR");

            /// <summary>
            /// Enum MODIFY_TASK_NUMBER for value: MODIFY_TASK_NUMBER
            /// </summary>
            public static readonly UnavailableActionsEnum MODIFY_TASK_NUMBER = new UnavailableActionsEnum("MODIFY_TASK_NUMBER");

            /// <summary>
            /// Enum CONTINUE_JOB for value: CONTINUE_JOB
            /// </summary>
            public static readonly UnavailableActionsEnum CONTINUE_JOB = new UnavailableActionsEnum("CONTINUE_JOB");

            /// <summary>
            /// Enum STOP_JOB for value: STOP_JOB
            /// </summary>
            public static readonly UnavailableActionsEnum STOP_JOB = new UnavailableActionsEnum("STOP_JOB");

            /// <summary>
            /// Enum CONTINUE_CAPTURE for value: CONTINUE_CAPTURE
            /// </summary>
            public static readonly UnavailableActionsEnum CONTINUE_CAPTURE = new UnavailableActionsEnum("CONTINUE_CAPTURE");

            /// <summary>
            /// Enum STOP_CAPTURE for value: STOP_CAPTURE
            /// </summary>
            public static readonly UnavailableActionsEnum STOP_CAPTURE = new UnavailableActionsEnum("STOP_CAPTURE");

            /// <summary>
            /// Enum CONTINUE_APPLY for value: CONTINUE_APPLY
            /// </summary>
            public static readonly UnavailableActionsEnum CONTINUE_APPLY = new UnavailableActionsEnum("CONTINUE_APPLY");

            /// <summary>
            /// Enum API_CONFIGURATION_ACTION for value: API_CONFIGURATION_ACTION
            /// </summary>
            public static readonly UnavailableActionsEnum API_CONFIGURATION_ACTION = new UnavailableActionsEnum("API_CONFIGURATION_ACTION");

            /// <summary>
            /// Enum STOP_APPLY for value: STOP_APPLY
            /// </summary>
            public static readonly UnavailableActionsEnum STOP_APPLY = new UnavailableActionsEnum("STOP_APPLY");

            /// <summary>
            /// Enum PAY_ORDER for value: PAY_ORDER
            /// </summary>
            public static readonly UnavailableActionsEnum PAY_ORDER = new UnavailableActionsEnum("PAY_ORDER");

            /// <summary>
            /// Enum UNSUBSCRIBE for value: UNSUBSCRIBE
            /// </summary>
            public static readonly UnavailableActionsEnum UNSUBSCRIBE = new UnavailableActionsEnum("UNSUBSCRIBE");

            /// <summary>
            /// Enum TO_PERIOD for value: TO_PERIOD
            /// </summary>
            public static readonly UnavailableActionsEnum TO_PERIOD = new UnavailableActionsEnum("TO_PERIOD");

            /// <summary>
            /// Enum TO_RENEW for value: TO_RENEW
            /// </summary>
            public static readonly UnavailableActionsEnum TO_RENEW = new UnavailableActionsEnum("TO_RENEW");

            /// <summary>
            /// Enum ORDER_INFO for value: ORDER_INFO
            /// </summary>
            public static readonly UnavailableActionsEnum ORDER_INFO = new UnavailableActionsEnum("ORDER_INFO");

            /// <summary>
            /// Enum CHANGE_FLAVOR for value: CHANGE_FLAVOR
            /// </summary>
            public static readonly UnavailableActionsEnum CHANGE_FLAVOR = new UnavailableActionsEnum("CHANGE_FLAVOR");

            /// <summary>
            /// Enum CLONE for value: CLONE
            /// </summary>
            public static readonly UnavailableActionsEnum CLONE = new UnavailableActionsEnum("CLONE");

            private static readonly Dictionary<string, UnavailableActionsEnum> StaticFields =
            new Dictionary<string, UnavailableActionsEnum>()
            {
                { "CREATE", CREATE },
                { "CHOOSE_OBJECT", CHOOSE_OBJECT },
                { "PRE_CHECK", PRE_CHECK },
                { "CHANGE_MODE", CHANGE_MODE },
                { "FREE_RESOURCE", FREE_RESOURCE },
                { "MODIFY_DB_CONFIG", MODIFY_DB_CONFIG },
                { "RESET_DB_PWD", RESET_DB_PWD },
                { "MODIFY_CONFIGURATION", MODIFY_CONFIGURATION },
                { "PAUSE", PAUSE },
                { "START", START },
                { "CHANGE", CHANGE },
                { "RETRY", RETRY },
                { "RESET", RESET },
                { "DELETE", DELETE },
                { "QUERY_PRE_CHECK", QUERY_PRE_CHECK },
                { "SWITCH_OVER", SWITCH_OVER },
                { "MODIFY_SPECIFICATION_ID", MODIFY_SPECIFICATION_ID },
                { "JUMP_RETRY", JUMP_RETRY },
                { "START_INCR", START_INCR },
                { "MODIFY_TASK_NUMBER", MODIFY_TASK_NUMBER },
                { "CONTINUE_JOB", CONTINUE_JOB },
                { "STOP_JOB", STOP_JOB },
                { "CONTINUE_CAPTURE", CONTINUE_CAPTURE },
                { "STOP_CAPTURE", STOP_CAPTURE },
                { "CONTINUE_APPLY", CONTINUE_APPLY },
                { "API_CONFIGURATION_ACTION", API_CONFIGURATION_ACTION },
                { "STOP_APPLY", STOP_APPLY },
                { "PAY_ORDER", PAY_ORDER },
                { "UNSUBSCRIBE", UNSUBSCRIBE },
                { "TO_PERIOD", TO_PERIOD },
                { "TO_RENEW", TO_RENEW },
                { "ORDER_INFO", ORDER_INFO },
                { "CHANGE_FLAVOR", CHANGE_FLAVOR },
                { "CLONE", CLONE },
            };

            private string _value;

            public UnavailableActionsEnum()
            {

            }

            public UnavailableActionsEnum(string value)
            {
                _value = value;
            }

            public static UnavailableActionsEnum FromValue(string value)
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

                if (this.Equals(obj as UnavailableActionsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UnavailableActionsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UnavailableActionsEnum a, UnavailableActionsEnum b)
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

            public static bool operator !=(UnavailableActionsEnum a, UnavailableActionsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 示例： SWITCH_OVER：灾备倒换中 STOP_JOB：任务暂停中
        /// </summary>
        /// <value>示例： SWITCH_OVER：灾备倒换中 STOP_JOB：任务暂停中</value>
        [JsonConverter(typeof(EnumClassConverter<CurrentActionEnum>))]
        public class CurrentActionEnum
        {
            /// <summary>
            /// Enum SWITCH_OVER for value: SWITCH_OVER
            /// </summary>
            public static readonly CurrentActionEnum SWITCH_OVER = new CurrentActionEnum("SWITCH_OVER");

            /// <summary>
            /// Enum STOP_JOB for value: STOP_JOB
            /// </summary>
            public static readonly CurrentActionEnum STOP_JOB = new CurrentActionEnum("STOP_JOB");

            private static readonly Dictionary<string, CurrentActionEnum> StaticFields =
            new Dictionary<string, CurrentActionEnum>()
            {
                { "SWITCH_OVER", SWITCH_OVER },
                { "STOP_JOB", STOP_JOB },
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
        /// 任务可操作命令集合。 取值： CREATE：创建任务 CHOOSE_OBJECT：选择对象 PRE_CHECK：预检查 CHANGE_MODE：修改任务模式 FREE_RESOURCE：释放资源 MODIFY_DB_CONFIG：修改数据库配置 RESET_DB_PWD：重置数据库密码（源库、目标库） MODIFY_CONFIGURATION：修改任务配置 PAUSE：暂停任务 START：启动任务 CHANGE：修改任务 RETRY：重试任务 RESET：重置任务 DELETE：删除任务 QUERY_PRE_CHECK：预检查 SWITCH_OVER：容灾倒换 START_INCR：CASSANDRA启动增量任务 MODIFY_TASK_NUMBER：CASSANDRA修改线程数配置 CONTINUE_JOB：oracle-GaussDB分布式:启动失败或者停止的任务 STOP_JOB：oracle-GaussDB分布式:停止任务 CONTINUE_CAPTURE：oracle-GaussDB分布式:启动抓取 STOP_CAPTURE：oracle-GaussDB分布式:停止抓取 CONTINUE_APPLY：oracle-GaussDB分布式:启动回放 STOP_APPLY：oracle-GaussDB分布式:停止回放 PAY_ORDER：包年包月支付订单 UNSUBSCRIBE：包年包月退订 TO_PERIOD：转包周期 TO_RENEW：包周期续费 ORDER_INFO：订单详情 CHANGE_FLAVOR：规格变更 CLONE：克隆任务
        /// </summary>
        [JsonProperty("available_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailableActionsEnum> AvailableActions { get; set; }
        /// <summary>
        /// 任务不可操作命令集合。 取值： CREATE：创建任务 CHOOSE_OBJECT：选择对象 PRE_CHECK：预检查 CHANGE_MODE：修改任务模式 FREE_RESOURCE：释放资源 MODIFY_DB_CONFIG：修改数据库配置 RESET_DB_PWD：重置数据库密码（源库、目标库） MODIFY_CONFIGURATION：修改任务配置 PAUSE：暂停任务 START：启动任务 CHANGE：修改任务 RETRY：重试任务 RESET：重置任务 DELETE：删除任务 QUERY_PRE_CHECK：预检查 SWITCH_OVER：容灾倒换 START_INCR：CASSANDRA启动增量任务 MODIFY_TASK_NUMBER：CASSANDRA修改线程数配置 CONTINUE_JOB：oracle-GaussDB分布式:启动失败或者停止的任务 STOP_JOB：oracle-GaussDB分布式:停止任务 CONTINUE_CAPTURE：oracle-GaussDB分布式:启动抓取 STOP_CAPTURE：oracle-GaussDB分布式:停止抓取 CONTINUE_APPLY：oracle-GaussDB分布式:启动回放 STOP_APPLY：oracle-GaussDB分布式:停止回放 PAY_ORDER：包年包月支付订单 UNSUBSCRIBE：包年包月退订 TO_PERIOD：转包周期 TO_RENEW：包周期续费 ORDER_INFO：订单详情 CHANGE_FLAVOR：规格变更 CLONE：克隆任务
        /// </summary>
        [JsonProperty("unavailable_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnavailableActionsEnum> UnavailableActions { get; set; }
        /// <summary>
        /// 示例： SWITCH_OVER：灾备倒换中 STOP_JOB：任务暂停中
        /// </summary>
        [JsonProperty("current_action", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentActionEnum CurrentAction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobActionResp {\n");
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
            return this.Equals(input as JobActionResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobActionResp input)
        {
            if (input == null) return false;
            if (this.AvailableActions != input.AvailableActions || (this.AvailableActions != null && input.AvailableActions != null && !this.AvailableActions.SequenceEqual(input.AvailableActions))) return false;
            if (this.UnavailableActions != input.UnavailableActions || (this.UnavailableActions != null && input.UnavailableActions != null && !this.UnavailableActions.SequenceEqual(input.UnavailableActions))) return false;
            if (this.CurrentAction != input.CurrentAction) return false;

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
                hashCode = hashCode * 59 + this.AvailableActions.GetHashCode();
                hashCode = hashCode * 59 + this.UnavailableActions.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
