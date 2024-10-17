using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 子模版数据结构
    /// </summary>
    public class SubTemplate 
    {
        /// <summary>
        /// 模板子类型，只支持以下5种类型：sms,dingding,wechat,webhook,email
        /// </summary>
        /// <value>模板子类型，只支持以下5种类型：sms,dingding,wechat,webhook,email</value>
        [JsonConverter(typeof(EnumClassConverter<SubTypeEnum>))]
        public class SubTypeEnum
        {
            /// <summary>
            /// Enum SMS for value: sms
            /// </summary>
            public static readonly SubTypeEnum SMS = new SubTypeEnum("sms");

            /// <summary>
            /// Enum DINGDING for value: dingding
            /// </summary>
            public static readonly SubTypeEnum DINGDING = new SubTypeEnum("dingding");

            /// <summary>
            /// Enum WECHAT for value: wechat
            /// </summary>
            public static readonly SubTypeEnum WECHAT = new SubTypeEnum("wechat");

            /// <summary>
            /// Enum WEBHOOK for value: webhook
            /// </summary>
            public static readonly SubTypeEnum WEBHOOK = new SubTypeEnum("webhook");

            /// <summary>
            /// Enum EMAIL for value: email
            /// </summary>
            public static readonly SubTypeEnum EMAIL = new SubTypeEnum("email");

            private static readonly Dictionary<string, SubTypeEnum> StaticFields =
            new Dictionary<string, SubTypeEnum>()
            {
                { "sms", SMS },
                { "dingding", DINGDING },
                { "wechat", WECHAT },
                { "webhook", WEBHOOK },
                { "email", EMAIL },
            };

            private string _value;

            public SubTypeEnum()
            {

            }

            public SubTypeEnum(string value)
            {
                _value = value;
            }

            public static SubTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SubTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SubTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SubTypeEnum a, SubTypeEnum b)
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

            public static bool operator !=(SubTypeEnum a, SubTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 模板子类型，只支持以下5种类型：sms,dingding,wechat,webhook,email
        /// </summary>
        [JsonProperty("sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubTypeEnum SubType { get; set; }
        /// <summary>
        /// 子模版正文，$符号后所跟变量仅支持以下变量，根据不同告警类型（关键词告警和sql告警），所支持的变量亦不相同。 目前两种告警类型有共同变量如下：告警级别：${event_severity};发生时间：${starts_at};告警源：$event.metadata.resource_provider;资源类型：$event.metadata.resource_type;资源标识：${resources};统计类型：关键词统计;表达式：$event.annotations.condition_expression;当前值: $event.annotations.current_value;统计周期：$event.annotations.frequency; 关键词告警特有变量：查询时间：$event.annotations.results[0].time;查询日志：$event.annotations.results[0].raw_results; sql告警特有变量：日志组/流名称：$event.annotations.results[0].resource_id;查询语句：$event.annotations.results[0].sql;查询时间：$event.annotations.results[0].time;查询URL：$event.annotations.results[0].url;查询日志：$event.annotations.results[0].raw_results; 变量后面的分号\&quot;;\&quot;为英文符号，必须添加，否则模板会出现替换失败的情况
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTemplate {\n");
            sb.Append("  subType: ").Append(SubType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubTemplate input)
        {
            if (input == null) return false;
            if (this.SubType != input.SubType) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;

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
                hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
