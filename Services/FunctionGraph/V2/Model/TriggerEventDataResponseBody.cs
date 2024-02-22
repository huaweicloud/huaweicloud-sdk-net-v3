using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 触发器源事件。
    /// </summary>
    public class TriggerEventDataResponseBody 
    {
        /// <summary>
        /// 定时触发类型（TIMER触发器参数）。 - Rate：指定固定频率（分钟、小时、天数）定期调用函数，单位为分钟时，输入值不能超过60；单位为小时时，输入值不能超过24；单位为天时，输入值不能超过30。 - Cron：指定Cron表达式定期调用函数
        /// </summary>
        /// <value>定时触发类型（TIMER触发器参数）。 - Rate：指定固定频率（分钟、小时、天数）定期调用函数，单位为分钟时，输入值不能超过60；单位为小时时，输入值不能超过24；单位为天时，输入值不能超过30。 - Cron：指定Cron表达式定期调用函数</value>
        [JsonConverter(typeof(EnumClassConverter<ScheduleTypeEnum>))]
        public class ScheduleTypeEnum
        {
            /// <summary>
            /// Enum RATE for value: Rate
            /// </summary>
            public static readonly ScheduleTypeEnum RATE = new ScheduleTypeEnum("Rate");

            /// <summary>
            /// Enum CRON for value: Cron
            /// </summary>
            public static readonly ScheduleTypeEnum CRON = new ScheduleTypeEnum("Cron");

            private static readonly Dictionary<string, ScheduleTypeEnum> StaticFields =
            new Dictionary<string, ScheduleTypeEnum>()
            {
                { "Rate", RATE },
                { "Cron", CRON },
            };

            private string _value;

            public ScheduleTypeEnum()
            {

            }

            public ScheduleTypeEnum(string value)
            {
                _value = value;
            }

            public static ScheduleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScheduleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScheduleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScheduleTypeEnum a, ScheduleTypeEnum b)
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

            public static bool operator !=(ScheduleTypeEnum a, ScheduleTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// API的请求协议（APIG触发器参数）。
        /// </summary>
        /// <value>API的请求协议（APIG触发器参数）。</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            public static readonly ProtocolEnum HTTP = new ProtocolEnum("HTTP");

            /// <summary>
            /// Enum HTTPS for value: HTTPS
            /// </summary>
            public static readonly ProtocolEnum HTTPS = new ProtocolEnum("HTTPS");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "HTTP", HTTP },
                { "HTTPS", HTTPS },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// API的请求方式（APIG触发器参数）。
        /// </summary>
        /// <value>API的请求方式（APIG触发器参数）。</value>
        [JsonConverter(typeof(EnumClassConverter<ReqMethodEnum>))]
        public class ReqMethodEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            public static readonly ReqMethodEnum GET = new ReqMethodEnum("GET");

            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            public static readonly ReqMethodEnum POST = new ReqMethodEnum("POST");

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            public static readonly ReqMethodEnum PUT = new ReqMethodEnum("PUT");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly ReqMethodEnum DELETE = new ReqMethodEnum("DELETE");

            /// <summary>
            /// Enum HEAD for value: HEAD
            /// </summary>
            public static readonly ReqMethodEnum HEAD = new ReqMethodEnum("HEAD");

            /// <summary>
            /// Enum PATCH for value: PATCH
            /// </summary>
            public static readonly ReqMethodEnum PATCH = new ReqMethodEnum("PATCH");

            /// <summary>
            /// Enum OPTIONS for value: OPTIONS
            /// </summary>
            public static readonly ReqMethodEnum OPTIONS = new ReqMethodEnum("OPTIONS");

            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            public static readonly ReqMethodEnum ANY = new ReqMethodEnum("ANY");

            private static readonly Dictionary<string, ReqMethodEnum> StaticFields =
            new Dictionary<string, ReqMethodEnum>()
            {
                { "GET", GET },
                { "POST", POST },
                { "PUT", PUT },
                { "DELETE", DELETE },
                { "HEAD", HEAD },
                { "PATCH", PATCH },
                { "OPTIONS", OPTIONS },
                { "ANY", ANY },
            };

            private string _value;

            public ReqMethodEnum()
            {

            }

            public ReqMethodEnum(string value)
            {
                _value = value;
            }

            public static ReqMethodEnum FromValue(string value)
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

                if (this.Equals(obj as ReqMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReqMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReqMethodEnum a, ReqMethodEnum b)
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

            public static bool operator !=(ReqMethodEnum a, ReqMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// API的匹配方式（APIG触发器参数）。 - SWA：前缀匹配 - NORMAL：正常匹配（绝对匹配）
        /// </summary>
        /// <value>API的匹配方式（APIG触发器参数）。 - SWA：前缀匹配 - NORMAL：正常匹配（绝对匹配）</value>
        [JsonConverter(typeof(EnumClassConverter<MatchModeEnum>))]
        public class MatchModeEnum
        {
            /// <summary>
            /// Enum SWA for value: SWA
            /// </summary>
            public static readonly MatchModeEnum SWA = new MatchModeEnum("SWA");

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly MatchModeEnum NORMAL = new MatchModeEnum("NORMAL");

            private static readonly Dictionary<string, MatchModeEnum> StaticFields =
            new Dictionary<string, MatchModeEnum>()
            {
                { "SWA", SWA },
                { "NORMAL", NORMAL },
            };

            private string _value;

            public MatchModeEnum()
            {

            }

            public MatchModeEnum(string value)
            {
                _value = value;
            }

            public static MatchModeEnum FromValue(string value)
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

                if (this.Equals(obj as MatchModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MatchModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MatchModeEnum a, MatchModeEnum b)
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

            public static bool operator !=(MatchModeEnum a, MatchModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// API的认证方式（APIG触发器参数）。 - IAM：IAM认证，只允许IAM用户能访问，安全级别中等 - APP：采用Appkey&amp;Appsecret认证，安全级别高，推荐使用 - NONE：无认证模式，所有用户均可访问，不推荐使用
        /// </summary>
        /// <value>API的认证方式（APIG触发器参数）。 - IAM：IAM认证，只允许IAM用户能访问，安全级别中等 - APP：采用Appkey&amp;Appsecret认证，安全级别高，推荐使用 - NONE：无认证模式，所有用户均可访问，不推荐使用</value>
        [JsonConverter(typeof(EnumClassConverter<AuthEnum>))]
        public class AuthEnum
        {
            /// <summary>
            /// Enum IAM for value: IAM
            /// </summary>
            public static readonly AuthEnum IAM = new AuthEnum("IAM");

            /// <summary>
            /// Enum APP for value: APP
            /// </summary>
            public static readonly AuthEnum APP = new AuthEnum("APP");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly AuthEnum NONE = new AuthEnum("NONE");

            private static readonly Dictionary<string, AuthEnum> StaticFields =
            new Dictionary<string, AuthEnum>()
            {
                { "IAM", IAM },
                { "APP", APP },
                { "NONE", NONE },
            };

            private string _value;

            public AuthEnum()
            {

            }

            public AuthEnum(string value)
            {
                _value = value;
            }

            public static AuthEnum FromValue(string value)
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

                if (this.Equals(obj as AuthEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthEnum a, AuthEnum b)
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

            public static bool operator !=(AuthEnum a, AuthEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// API的后端类型（APIG触发器参数）。
        /// </summary>
        /// <value>API的后端类型（APIG触发器参数）。</value>
        [JsonConverter(typeof(EnumClassConverter<BackendTypeEnum>))]
        public class BackendTypeEnum
        {
            /// <summary>
            /// Enum FUNCTION for value: FUNCTION
            /// </summary>
            public static readonly BackendTypeEnum FUNCTION = new BackendTypeEnum("FUNCTION");

            private static readonly Dictionary<string, BackendTypeEnum> StaticFields =
            new Dictionary<string, BackendTypeEnum>()
            {
                { "FUNCTION", FUNCTION },
            };

            private string _value;

            public BackendTypeEnum()
            {

            }

            public BackendTypeEnum(string value)
            {
                _value = value;
            }

            public static BackendTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BackendTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackendTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackendTypeEnum a, BackendTypeEnum b)
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

            public static bool operator !=(BackendTypeEnum a, BackendTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 起始位置（DIS触发器参数）。 - TRIM_HORIZON：从最早被存储至分区的有效记录开始读取。 - LATEST：从分区中的最新记录开始读取，此设置可以保证总是读到分区中最新记录。
        /// </summary>
        /// <value>起始位置（DIS触发器参数）。 - TRIM_HORIZON：从最早被存储至分区的有效记录开始读取。 - LATEST：从分区中的最新记录开始读取，此设置可以保证总是读到分区中最新记录。</value>
        [JsonConverter(typeof(EnumClassConverter<SharditeratorTypeEnum>))]
        public class SharditeratorTypeEnum
        {
            /// <summary>
            /// Enum TRIM_HORIZON for value: TRIM_HORIZON
            /// </summary>
            public static readonly SharditeratorTypeEnum TRIM_HORIZON = new SharditeratorTypeEnum("TRIM_HORIZON");

            /// <summary>
            /// Enum LATEST for value: LATEST
            /// </summary>
            public static readonly SharditeratorTypeEnum LATEST = new SharditeratorTypeEnum("LATEST");

            private static readonly Dictionary<string, SharditeratorTypeEnum> StaticFields =
            new Dictionary<string, SharditeratorTypeEnum>()
            {
                { "TRIM_HORIZON", TRIM_HORIZON },
                { "LATEST", LATEST },
            };

            private string _value;

            public SharditeratorTypeEnum()
            {

            }

            public SharditeratorTypeEnum(string value)
            {
                _value = value;
            }

            public static SharditeratorTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SharditeratorTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SharditeratorTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SharditeratorTypeEnum a, SharditeratorTypeEnum b)
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

            public static bool operator !=(SharditeratorTypeEnum a, SharditeratorTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 拉取周期单位（DIS触发器参数）。 - s：秒 - ms：毫秒
        /// </summary>
        /// <value>拉取周期单位（DIS触发器参数）。 - s：秒 - ms：毫秒</value>
        [JsonConverter(typeof(EnumClassConverter<PollingUnitEnum>))]
        public class PollingUnitEnum
        {
            /// <summary>
            /// Enum S for value: s
            /// </summary>
            public static readonly PollingUnitEnum S = new PollingUnitEnum("s");

            /// <summary>
            /// Enum MS for value: ms
            /// </summary>
            public static readonly PollingUnitEnum MS = new PollingUnitEnum("ms");

            private static readonly Dictionary<string, PollingUnitEnum> StaticFields =
            new Dictionary<string, PollingUnitEnum>()
            {
                { "s", S },
                { "ms", MS },
            };

            private string _value;

            public PollingUnitEnum()
            {

            }

            public PollingUnitEnum(string value)
            {
                _value = value;
            }

            public static PollingUnitEnum FromValue(string value)
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

                if (this.Equals(obj as PollingUnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PollingUnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PollingUnitEnum a, PollingUnitEnum b)
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

            public static bool operator !=(PollingUnitEnum a, PollingUnitEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 串行处理数据（DIS触发器参数），如果开启该选项，取一次数据处理完之后才会取下一次数据；否则只要拉取周期到了就会取数据进行处理。
        /// </summary>
        /// <value>串行处理数据（DIS触发器参数），如果开启该选项，取一次数据处理完之后才会取下一次数据；否则只要拉取周期到了就会取数据进行处理。</value>
        [JsonConverter(typeof(EnumClassConverter<IsSerialEnum>))]
        public class IsSerialEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsSerialEnum TRUE = new IsSerialEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsSerialEnum FALSE = new IsSerialEnum("false");

            private static readonly Dictionary<string, IsSerialEnum> StaticFields =
            new Dictionary<string, IsSerialEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsSerialEnum()
            {

            }

            public IsSerialEnum(string value)
            {
                _value = value;
            }

            public static IsSerialEnum FromValue(string value)
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

                if (this.Equals(obj as IsSerialEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsSerialEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsSerialEnum a, IsSerialEnum b)
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

            public static bool operator !=(IsSerialEnum a, IsSerialEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 触发器名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 定时触发类型（TIMER触发器参数）。 - Rate：指定固定频率（分钟、小时、天数）定期调用函数，单位为分钟时，输入值不能超过60；单位为小时时，输入值不能超过24；单位为天时，输入值不能超过30。 - Cron：指定Cron表达式定期调用函数
        /// </summary>
        [JsonProperty("schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduleTypeEnum ScheduleType { get; set; }
        /// <summary>
        /// 定时触发规则（TIMER触发器参数）。 - 触发类型为Rate时对应定时规则 - 触发类型为Cron时对应Cron表达式
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public string Schedule { get; set; }

        /// <summary>
        /// 附加信息（TIMER触发器参数）。 当Timer触发器触发函数执行时，执行事件（函数的event参数）为： {\&quot;version\&quot;: \&quot;v1.0\&quot;,   \&quot;time\&quot;: \&quot;2018-06-01T08:30:00+08:00\&quot;,   \&quot;trigger_type\&quot;: \&quot;TIMER\&quot;,   \&quot;trigger_name\&quot;: \&quot;Timer_001\&quot;,   \&quot;user_event\&quot;: \&quot;您输入的附加信息\&quot;}
        /// </summary>
        [JsonProperty("user_event", NullValueHandling = NullValueHandling.Ignore)]
        public string UserEvent { get; set; }

        /// <summary>
        /// APIG触发器id。（APIG触发器参数）
        /// </summary>
        [JsonProperty("triggerid", NullValueHandling = NullValueHandling.Ignore)]
        public string Triggerid { get; set; }

        /// <summary>
        /// API接口类型（APIG触发器参数）。 - 1：公有API - 2：私有API
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// APIG接口PATH路径（APIG触发器参数）。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// API的请求协议（APIG触发器参数）。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// API的请求方式（APIG触发器参数）。
        /// </summary>
        [JsonProperty("req_method", NullValueHandling = NullValueHandling.Ignore)]
        public ReqMethodEnum ReqMethod { get; set; }
        /// <summary>
        /// API所属的分组编号（APIG触发器参数）。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// API所属的分组名称（APIG触发器参数）。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// API的匹配方式（APIG触发器参数）。 - SWA：前缀匹配 - NORMAL：正常匹配（绝对匹配）
        /// </summary>
        [JsonProperty("match_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MatchModeEnum MatchMode { get; set; }
        /// <summary>
        /// API的发布环境（APIG触发器参数）。
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// API的发布环境id（APIG触发器参数）。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvId { get; set; }

        /// <summary>
        /// API编号（APIG触发器参数）。
        /// </summary>
        [JsonProperty("api_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>
        /// API名称（APIG触发器参数）。
        /// </summary>
        [JsonProperty("api_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiName { get; set; }

        /// <summary>
        /// API的认证方式（APIG触发器参数）。 - IAM：IAM认证，只允许IAM用户能访问，安全级别中等 - APP：采用Appkey&amp;Appsecret认证，安全级别高，推荐使用 - NONE：无认证模式，所有用户均可访问，不推荐使用
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public AuthEnum Auth { get; set; }
        /// <summary>
        /// API调用地址（APIG触发器参数）。
        /// </summary>
        [JsonProperty("invoke_url", NullValueHandling = NullValueHandling.Ignore)]
        public string InvokeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("func_info", NullValueHandling = NullValueHandling.Ignore)]
        public ApigTriggerFuncInfo FuncInfo { get; set; }

        /// <summary>
        /// APIG系统默认分配的子域名（APIG触发器参数）。
        /// </summary>
        [JsonProperty("sl_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string SlDomain { get; set; }

        /// <summary>
        /// API的后端类型（APIG触发器参数）。
        /// </summary>
        [JsonProperty("backend_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackendTypeEnum BackendType { get; set; }
        /// <summary>
        /// 实例id。DDS、KAFKA、RABBITMQ触发器此参数必填。 - APIG触发器：apig实例id - DDS触发器：文档数据库实例id - KAFKA触发器：KAFKA实例id - RABBITMQ触发器：RABBITMQ实例id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// API归属的集成应用编号。（APIG触发器参数）
        /// </summary>
        [JsonProperty("roma_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RomaAppId { get; set; }

        /// <summary>
        /// 自定义操作（CTS触发器参数）。 CTS云审计服务类型和操作订阅所需要的事件通知，当CTS云审计服务获取已订阅的操作记录后，通过CTS触发器将采集到的操作记录作为参数传递来调用FunctionGraph函数。
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Operations { get; set; }

        /// <summary>
        /// 集合名称（DDS触发器参数）。
        /// </summary>
        [JsonProperty("collection_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionName { get; set; }

        /// <summary>
        /// 文档数据库名称（DDS触发器参数）。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 文档数据库密码（DDS触发器参数）。
        /// </summary>
        [JsonProperty("db_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPassword { get; set; }

        /// <summary>
        /// 文档数据库用户名（DDS触发器参数）。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 文档数据库实例地址（DDS触发器参数）。
        /// </summary>
        [JsonProperty("instance_addrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceAddrs { get; set; }

        /// <summary>
        /// 文档数据库实例类型（DDS触发器参数）。 - Sharding：集群实例 - ReplicaSet：副本集实例 - Single：单节点实例
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 批处理大小，单次函数执行处理的最大数据量。DIS、DDS、KAFKA、RABBITMQ触发器此参数必填。 - DDS触发器：批处理大小设置1-10,000的范围内 - DIS触发器：批处理大小设置1-10,000的范围内 - KAFKA触发器：批处理大小设置1-1,000的范围内 - RABBITMQ触发器：批处理大小设置1-1,000的范围内
        /// </summary>
        [JsonProperty("batch_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 队列id（DMS触发器参数）。
        /// </summary>
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 消费组id（DMS触发器参数）。
        /// </summary>
        [JsonProperty("consumer_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// 拉取周期。
        /// </summary>
        [JsonProperty("polling_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? PollingInterval { get; set; }

        /// <summary>
        /// 通道名称（DIS触发器参数）。
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }

        /// <summary>
        /// 起始位置（DIS触发器参数）。 - TRIM_HORIZON：从最早被存储至分区的有效记录开始读取。 - LATEST：从分区中的最新记录开始读取，此设置可以保证总是读到分区中最新记录。
        /// </summary>
        [JsonProperty("sharditerator_type", NullValueHandling = NullValueHandling.Ignore)]
        public SharditeratorTypeEnum SharditeratorType { get; set; }
        /// <summary>
        /// 拉取周期单位（DIS触发器参数）。 - s：秒 - ms：毫秒
        /// </summary>
        [JsonProperty("polling_unit", NullValueHandling = NullValueHandling.Ignore)]
        public PollingUnitEnum PollingUnit { get; set; }
        /// <summary>
        /// 最大提取字节数（DIS触发器参数）。
        /// </summary>
        [JsonProperty("max_fetch_bytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxFetchBytes { get; set; }

        /// <summary>
        /// 串行处理数据（DIS触发器参数），如果开启该选项，取一次数据处理完之后才会取下一次数据；否则只要拉取周期到了就会取数据进行处理。
        /// </summary>
        [JsonProperty("is_serial", NullValueHandling = NullValueHandling.Ignore)]
        public IsSerialEnum IsSerial { get; set; }
        /// <summary>
        /// 日志组id（LTS触发器参数）。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志流id（LTS触发器参数）。
        /// </summary>
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicId { get; set; }

        /// <summary>
        /// 桶名称（OBS触发器参数），用作事件源的OBS存储桶，不能和本用户已有桶重名；不能和其他用户已有的桶重名；创建成功后不支持修改。
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 前缀（OBS触发器参数），输入一个可选性前缀来限制对以此关键字开头的对象的通知。
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// 后缀（OBS触发器参数），输入一个可选性后缀来限制对以此关键字结尾的对象的通知
        /// </summary>
        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        /// <summary>
        /// 触发事件（OBS触发器参数）。 - ObjectCreated：表示所有创建对象的操作，包含Put、Post、Copy对象以及合并段 - Put：使用Put方法上传对象 - Post：使用Post方法上传对象 - Copy：使用copy方法复制对象 - CompleteMultipartUpload：表示合并分段任务 - ObjectRemoved：表示删除对象 - Delete：指定对象版本号删除对象 - DeleteMarkerCreated：不指定对象版本号删除对象
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Events { get; set; }

        /// <summary>
        /// 主题URN（SMN触发器参数）。
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// KAFKA主题id列表（KAFKA触发器参数）。
        /// </summary>
        [JsonProperty("topic_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TopicIds { get; set; }

        /// <summary>
        /// KAFKA账户名（KAFKA触发器参数）。
        /// </summary>
        [JsonProperty("kafka_user", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaUser { get; set; }

        /// <summary>
        /// KAFKA账户密码（KAFKA触发器参数）。
        /// </summary>
        [JsonProperty("kafka_password", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPassword { get; set; }

        /// <summary>
        /// KAFKA实例连接IP地址（KAFKA触发器参数）。
        /// </summary>
        [JsonProperty("kafka_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaConnectAddress { get; set; }

        /// <summary>
        /// KAFKA连接是否开启安全认证（KAFKA触发器参数）。
        /// </summary>
        [JsonProperty("kafka_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KafkaSslEnable { get; set; }

        /// <summary>
        /// RABBITMQ账户密码（RABBITMQ触发器参数）。
        /// </summary>
        [JsonProperty("access_password", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPassword { get; set; }

        /// <summary>
        /// RABBITMQ账户名（RABBITMQ触发器参数）。
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

        /// <summary>
        /// 实例连接IP地址（RABBITMQ触发器参数）。
        /// </summary>
        [JsonProperty("connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectAddress { get; set; }

        /// <summary>
        /// 交换机名称（RABBITMQ触发器参数）。
        /// </summary>
        [JsonProperty("exchange_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeName { get; set; }

        /// <summary>
        /// 虚拟机名称（RABBITMQ触发器参数）。
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// RABBITMQ连接是否开启安全认证（RABBITMQ触发器参数）。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerEventDataResponseBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  scheduleType: ").Append(ScheduleType).Append("\n");
            sb.Append("  schedule: ").Append(Schedule).Append("\n");
            sb.Append("  userEvent: ").Append(UserEvent).Append("\n");
            sb.Append("  triggerid: ").Append(Triggerid).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  reqMethod: ").Append(ReqMethod).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  matchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  apiId: ").Append(ApiId).Append("\n");
            sb.Append("  apiName: ").Append(ApiName).Append("\n");
            sb.Append("  auth: ").Append(Auth).Append("\n");
            sb.Append("  invokeUrl: ").Append(InvokeUrl).Append("\n");
            sb.Append("  funcInfo: ").Append(FuncInfo).Append("\n");
            sb.Append("  slDomain: ").Append(SlDomain).Append("\n");
            sb.Append("  backendType: ").Append(BackendType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  romaAppId: ").Append(RomaAppId).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  collectionName: ").Append(CollectionName).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  dbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  instanceAddrs: ").Append(InstanceAddrs).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  batchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  consumerGroupId: ").Append(ConsumerGroupId).Append("\n");
            sb.Append("  pollingInterval: ").Append(PollingInterval).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("  sharditeratorType: ").Append(SharditeratorType).Append("\n");
            sb.Append("  pollingUnit: ").Append(PollingUnit).Append("\n");
            sb.Append("  maxFetchBytes: ").Append(MaxFetchBytes).Append("\n");
            sb.Append("  isSerial: ").Append(IsSerial).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  suffix: ").Append(Suffix).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  topicIds: ").Append(TopicIds).Append("\n");
            sb.Append("  kafkaUser: ").Append(KafkaUser).Append("\n");
            sb.Append("  kafkaPassword: ").Append(KafkaPassword).Append("\n");
            sb.Append("  kafkaConnectAddress: ").Append(KafkaConnectAddress).Append("\n");
            sb.Append("  kafkaSslEnable: ").Append(KafkaSslEnable).Append("\n");
            sb.Append("  accessPassword: ").Append(AccessPassword).Append("\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  connectAddress: ").Append(ConnectAddress).Append("\n");
            sb.Append("  exchangeName: ").Append(ExchangeName).Append("\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriggerEventDataResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerEventDataResponseBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ScheduleType == input.ScheduleType ||
                    (this.ScheduleType != null &&
                    this.ScheduleType.Equals(input.ScheduleType))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.UserEvent == input.UserEvent ||
                    (this.UserEvent != null &&
                    this.UserEvent.Equals(input.UserEvent))
                ) && 
                (
                    this.Triggerid == input.Triggerid ||
                    (this.Triggerid != null &&
                    this.Triggerid.Equals(input.Triggerid))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.ReqMethod == input.ReqMethod ||
                    (this.ReqMethod != null &&
                    this.ReqMethod.Equals(input.ReqMethod))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.MatchMode == input.MatchMode ||
                    (this.MatchMode != null &&
                    this.MatchMode.Equals(input.MatchMode))
                ) && 
                (
                    this.EnvName == input.EnvName ||
                    (this.EnvName != null &&
                    this.EnvName.Equals(input.EnvName))
                ) && 
                (
                    this.EnvId == input.EnvId ||
                    (this.EnvId != null &&
                    this.EnvId.Equals(input.EnvId))
                ) && 
                (
                    this.ApiId == input.ApiId ||
                    (this.ApiId != null &&
                    this.ApiId.Equals(input.ApiId))
                ) && 
                (
                    this.ApiName == input.ApiName ||
                    (this.ApiName != null &&
                    this.ApiName.Equals(input.ApiName))
                ) && 
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))
                ) && 
                (
                    this.InvokeUrl == input.InvokeUrl ||
                    (this.InvokeUrl != null &&
                    this.InvokeUrl.Equals(input.InvokeUrl))
                ) && 
                (
                    this.FuncInfo == input.FuncInfo ||
                    (this.FuncInfo != null &&
                    this.FuncInfo.Equals(input.FuncInfo))
                ) && 
                (
                    this.SlDomain == input.SlDomain ||
                    (this.SlDomain != null &&
                    this.SlDomain.Equals(input.SlDomain))
                ) && 
                (
                    this.BackendType == input.BackendType ||
                    (this.BackendType != null &&
                    this.BackendType.Equals(input.BackendType))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.RomaAppId == input.RomaAppId ||
                    (this.RomaAppId != null &&
                    this.RomaAppId.Equals(input.RomaAppId))
                ) && 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    input.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.CollectionName == input.CollectionName ||
                    (this.CollectionName != null &&
                    this.CollectionName.Equals(input.CollectionName))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.DbPassword == input.DbPassword ||
                    (this.DbPassword != null &&
                    this.DbPassword.Equals(input.DbPassword))
                ) && 
                (
                    this.DbUser == input.DbUser ||
                    (this.DbUser != null &&
                    this.DbUser.Equals(input.DbUser))
                ) && 
                (
                    this.InstanceAddrs == input.InstanceAddrs ||
                    this.InstanceAddrs != null &&
                    input.InstanceAddrs != null &&
                    this.InstanceAddrs.SequenceEqual(input.InstanceAddrs)
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.BatchSize == input.BatchSize ||
                    (this.BatchSize != null &&
                    this.BatchSize.Equals(input.BatchSize))
                ) && 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.ConsumerGroupId == input.ConsumerGroupId ||
                    (this.ConsumerGroupId != null &&
                    this.ConsumerGroupId.Equals(input.ConsumerGroupId))
                ) && 
                (
                    this.PollingInterval == input.PollingInterval ||
                    (this.PollingInterval != null &&
                    this.PollingInterval.Equals(input.PollingInterval))
                ) && 
                (
                    this.StreamName == input.StreamName ||
                    (this.StreamName != null &&
                    this.StreamName.Equals(input.StreamName))
                ) && 
                (
                    this.SharditeratorType == input.SharditeratorType ||
                    (this.SharditeratorType != null &&
                    this.SharditeratorType.Equals(input.SharditeratorType))
                ) && 
                (
                    this.PollingUnit == input.PollingUnit ||
                    (this.PollingUnit != null &&
                    this.PollingUnit.Equals(input.PollingUnit))
                ) && 
                (
                    this.MaxFetchBytes == input.MaxFetchBytes ||
                    (this.MaxFetchBytes != null &&
                    this.MaxFetchBytes.Equals(input.MaxFetchBytes))
                ) && 
                (
                    this.IsSerial == input.IsSerial ||
                    (this.IsSerial != null &&
                    this.IsSerial.Equals(input.IsSerial))
                ) && 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogTopicId == input.LogTopicId ||
                    (this.LogTopicId != null &&
                    this.LogTopicId.Equals(input.LogTopicId))
                ) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.TopicUrn == input.TopicUrn ||
                    (this.TopicUrn != null &&
                    this.TopicUrn.Equals(input.TopicUrn))
                ) && 
                (
                    this.TopicIds == input.TopicIds ||
                    this.TopicIds != null &&
                    input.TopicIds != null &&
                    this.TopicIds.SequenceEqual(input.TopicIds)
                ) && 
                (
                    this.KafkaUser == input.KafkaUser ||
                    (this.KafkaUser != null &&
                    this.KafkaUser.Equals(input.KafkaUser))
                ) && 
                (
                    this.KafkaPassword == input.KafkaPassword ||
                    (this.KafkaPassword != null &&
                    this.KafkaPassword.Equals(input.KafkaPassword))
                ) && 
                (
                    this.KafkaConnectAddress == input.KafkaConnectAddress ||
                    (this.KafkaConnectAddress != null &&
                    this.KafkaConnectAddress.Equals(input.KafkaConnectAddress))
                ) && 
                (
                    this.KafkaSslEnable == input.KafkaSslEnable ||
                    (this.KafkaSslEnable != null &&
                    this.KafkaSslEnable.Equals(input.KafkaSslEnable))
                ) && 
                (
                    this.AccessPassword == input.AccessPassword ||
                    (this.AccessPassword != null &&
                    this.AccessPassword.Equals(input.AccessPassword))
                ) && 
                (
                    this.AccessUser == input.AccessUser ||
                    (this.AccessUser != null &&
                    this.AccessUser.Equals(input.AccessUser))
                ) && 
                (
                    this.ConnectAddress == input.ConnectAddress ||
                    (this.ConnectAddress != null &&
                    this.ConnectAddress.Equals(input.ConnectAddress))
                ) && 
                (
                    this.ExchangeName == input.ExchangeName ||
                    (this.ExchangeName != null &&
                    this.ExchangeName.Equals(input.ExchangeName))
                ) && 
                (
                    this.Vhost == input.Vhost ||
                    (this.Vhost != null &&
                    this.Vhost.Equals(input.Vhost))
                ) && 
                (
                    this.SslEnable == input.SslEnable ||
                    (this.SslEnable != null &&
                    this.SslEnable.Equals(input.SslEnable))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ScheduleType != null)
                    hashCode = hashCode * 59 + this.ScheduleType.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.UserEvent != null)
                    hashCode = hashCode * 59 + this.UserEvent.GetHashCode();
                if (this.Triggerid != null)
                    hashCode = hashCode * 59 + this.Triggerid.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ReqMethod != null)
                    hashCode = hashCode * 59 + this.ReqMethod.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.MatchMode != null)
                    hashCode = hashCode * 59 + this.MatchMode.GetHashCode();
                if (this.EnvName != null)
                    hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.EnvId != null)
                    hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.ApiId != null)
                    hashCode = hashCode * 59 + this.ApiId.GetHashCode();
                if (this.ApiName != null)
                    hashCode = hashCode * 59 + this.ApiName.GetHashCode();
                if (this.Auth != null)
                    hashCode = hashCode * 59 + this.Auth.GetHashCode();
                if (this.InvokeUrl != null)
                    hashCode = hashCode * 59 + this.InvokeUrl.GetHashCode();
                if (this.FuncInfo != null)
                    hashCode = hashCode * 59 + this.FuncInfo.GetHashCode();
                if (this.SlDomain != null)
                    hashCode = hashCode * 59 + this.SlDomain.GetHashCode();
                if (this.BackendType != null)
                    hashCode = hashCode * 59 + this.BackendType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.RomaAppId != null)
                    hashCode = hashCode * 59 + this.RomaAppId.GetHashCode();
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.CollectionName != null)
                    hashCode = hashCode * 59 + this.CollectionName.GetHashCode();
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.DbPassword != null)
                    hashCode = hashCode * 59 + this.DbPassword.GetHashCode();
                if (this.DbUser != null)
                    hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.InstanceAddrs != null)
                    hashCode = hashCode * 59 + this.InstanceAddrs.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.BatchSize != null)
                    hashCode = hashCode * 59 + this.BatchSize.GetHashCode();
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.ConsumerGroupId != null)
                    hashCode = hashCode * 59 + this.ConsumerGroupId.GetHashCode();
                if (this.PollingInterval != null)
                    hashCode = hashCode * 59 + this.PollingInterval.GetHashCode();
                if (this.StreamName != null)
                    hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                if (this.SharditeratorType != null)
                    hashCode = hashCode * 59 + this.SharditeratorType.GetHashCode();
                if (this.PollingUnit != null)
                    hashCode = hashCode * 59 + this.PollingUnit.GetHashCode();
                if (this.MaxFetchBytes != null)
                    hashCode = hashCode * 59 + this.MaxFetchBytes.GetHashCode();
                if (this.IsSerial != null)
                    hashCode = hashCode * 59 + this.IsSerial.GetHashCode();
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogTopicId != null)
                    hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.TopicUrn != null)
                    hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.TopicIds != null)
                    hashCode = hashCode * 59 + this.TopicIds.GetHashCode();
                if (this.KafkaUser != null)
                    hashCode = hashCode * 59 + this.KafkaUser.GetHashCode();
                if (this.KafkaPassword != null)
                    hashCode = hashCode * 59 + this.KafkaPassword.GetHashCode();
                if (this.KafkaConnectAddress != null)
                    hashCode = hashCode * 59 + this.KafkaConnectAddress.GetHashCode();
                if (this.KafkaSslEnable != null)
                    hashCode = hashCode * 59 + this.KafkaSslEnable.GetHashCode();
                if (this.AccessPassword != null)
                    hashCode = hashCode * 59 + this.AccessPassword.GetHashCode();
                if (this.AccessUser != null)
                    hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                if (this.ConnectAddress != null)
                    hashCode = hashCode * 59 + this.ConnectAddress.GetHashCode();
                if (this.ExchangeName != null)
                    hashCode = hashCode * 59 + this.ExchangeName.GetHashCode();
                if (this.Vhost != null)
                    hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.SslEnable != null)
                    hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
