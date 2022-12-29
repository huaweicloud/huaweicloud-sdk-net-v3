using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 固定返回页面的配置。  当监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效，未开启传入该字段会报错。  当action为FIXED_RESPONSE时生效，且为必选字段，其他action不可指定，否则报错。  [共享型负载均衡器下的转发策略不支持该字段，传入会报错。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt,hk_tm)  [不支持该字段，请勿使用。](tag:hcso_dt)  [荷兰region不支持该字段，请勿使用。](tag:dt)
    /// </summary>
    public class CreateFixtedResponseConfig 
    {
        /// <summary>
        /// 返回body的格式。  取值范围： - text/plain - text/css - text/html - application/javascript - application/json
        /// </summary>
        /// <value>返回body的格式。  取值范围： - text/plain - text/css - text/html - application/javascript - application/json</value>
        [JsonConverter(typeof(EnumClassConverter<ContentTypeEnum>))]
        public class ContentTypeEnum
        {
            /// <summary>
            /// Enum TEXT_PLAIN for value: text/plain
            /// </summary>
            public static readonly ContentTypeEnum TEXT_PLAIN = new ContentTypeEnum("text/plain");

            /// <summary>
            /// Enum TEXT_CSS for value: text/css
            /// </summary>
            public static readonly ContentTypeEnum TEXT_CSS = new ContentTypeEnum("text/css");

            /// <summary>
            /// Enum TEXT_HTML for value: text/html
            /// </summary>
            public static readonly ContentTypeEnum TEXT_HTML = new ContentTypeEnum("text/html");

            /// <summary>
            /// Enum APPLICATION_JAVASCRIPT for value: application/javascript
            /// </summary>
            public static readonly ContentTypeEnum APPLICATION_JAVASCRIPT = new ContentTypeEnum("application/javascript");

            /// <summary>
            /// Enum APPLICATION_JSON for value: application/json
            /// </summary>
            public static readonly ContentTypeEnum APPLICATION_JSON = new ContentTypeEnum("application/json");

            private static readonly Dictionary<string, ContentTypeEnum> StaticFields =
            new Dictionary<string, ContentTypeEnum>()
            {
                { "text/plain", TEXT_PLAIN },
                { "text/css", TEXT_CSS },
                { "text/html", TEXT_HTML },
                { "application/javascript", APPLICATION_JAVASCRIPT },
                { "application/json", APPLICATION_JSON },
            };

            private string _value;

            public ContentTypeEnum()
            {

            }

            public ContentTypeEnum(string value)
            {
                _value = value;
            }

            public static ContentTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ContentTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ContentTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ContentTypeEnum a, ContentTypeEnum b)
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

            public static bool operator !=(ContentTypeEnum a, ContentTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 返回码。支持200~299,400~499,500~599。
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusCode { get; set; }

        /// <summary>
        /// 返回body的格式。  取值范围： - text/plain - text/css - text/html - application/javascript - application/json
        /// </summary>
        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public ContentTypeEnum ContentType { get; set; }
        /// <summary>
        /// 返回消息内容。
        /// </summary>
        [JsonProperty("message_body", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageBody { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFixtedResponseConfig {\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  messageBody: ").Append(MessageBody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFixtedResponseConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFixtedResponseConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.MessageBody == input.MessageBody ||
                    (this.MessageBody != null &&
                    this.MessageBody.Equals(input.MessageBody))
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
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.MessageBody != null)
                    hashCode = hashCode * 59 + this.MessageBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
