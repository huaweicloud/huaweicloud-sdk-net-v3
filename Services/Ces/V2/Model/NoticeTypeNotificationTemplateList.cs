using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NoticeTypeNotificationTemplateList 
    {
        /// <summary>
        /// 通知类型, sms(短信)/email/http(s)/smn/welink/dingding(钉钉)/wechat(微信)/feishu(飞书)/wecomgroup(微信企业版)
        /// </summary>
        /// <value>通知类型, sms(短信)/email/http(s)/smn/welink/dingding(钉钉)/wechat(微信)/feishu(飞书)/wecomgroup(微信企业版)</value>
        [JsonConverter(typeof(EnumClassConverter<NoticeTypeEnum>))]
        public class NoticeTypeEnum
        {
            /// <summary>
            /// Enum SMS for value: sms
            /// </summary>
            public static readonly NoticeTypeEnum SMS = new NoticeTypeEnum("sms");

            /// <summary>
            /// Enum EMAIL for value: email
            /// </summary>
            public static readonly NoticeTypeEnum EMAIL = new NoticeTypeEnum("email");

            /// <summary>
            /// Enum HTTP_S_ for value: http(s)
            /// </summary>
            public static readonly NoticeTypeEnum HTTP_S_ = new NoticeTypeEnum("http(s)");

            /// <summary>
            /// Enum SMN for value: smn
            /// </summary>
            public static readonly NoticeTypeEnum SMN = new NoticeTypeEnum("smn");

            /// <summary>
            /// Enum WELINK for value: welink
            /// </summary>
            public static readonly NoticeTypeEnum WELINK = new NoticeTypeEnum("welink");

            /// <summary>
            /// Enum DINGDING for value: dingding
            /// </summary>
            public static readonly NoticeTypeEnum DINGDING = new NoticeTypeEnum("dingding");

            /// <summary>
            /// Enum WECHAT for value: wechat
            /// </summary>
            public static readonly NoticeTypeEnum WECHAT = new NoticeTypeEnum("wechat");

            /// <summary>
            /// Enum FEISHU for value: feishu
            /// </summary>
            public static readonly NoticeTypeEnum FEISHU = new NoticeTypeEnum("feishu");

            /// <summary>
            /// Enum WECOMGROUP for value: wecomgroup
            /// </summary>
            public static readonly NoticeTypeEnum WECOMGROUP = new NoticeTypeEnum("wecomgroup");

            private static readonly Dictionary<string, NoticeTypeEnum> StaticFields =
            new Dictionary<string, NoticeTypeEnum>()
            {
                { "sms", SMS },
                { "email", EMAIL },
                { "http(s)", HTTP_S_ },
                { "smn", SMN },
                { "welink", WELINK },
                { "dingding", DINGDING },
                { "wechat", WECHAT },
                { "feishu", FEISHU },
                { "wecomgroup", WECOMGROUP },
            };

            private string _value;

            public NoticeTypeEnum()
            {

            }

            public NoticeTypeEnum(string value)
            {
                _value = value;
            }

            public static NoticeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NoticeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NoticeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NoticeTypeEnum a, NoticeTypeEnum b)
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

            public static bool operator !=(NoticeTypeEnum a, NoticeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通知类型, sms(短信)/email/http(s)/smn/welink/dingding(钉钉)/wechat(微信)/feishu(飞书)/wecomgroup(微信企业版)
        /// </summary>
        [JsonProperty("notice_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoticeTypeEnum NoticeType { get; set; }
        /// <summary>
        /// **参数解释**： 通知模板id **约束限制**： 不涉及。 **取值范围**： 长度为[3,64]个字符。 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("alarm_notification_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmNotificationTemplateId { get; set; }

        /// <summary>
        /// **参数解释**： 通知模板名 **约束限制**： 不涉及。 **取值范围**： 长度为[1,200]个字符。 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("alarm_notification_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmNotificationTemplateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoticeTypeNotificationTemplateList {\n");
            sb.Append("  noticeType: ").Append(NoticeType).Append("\n");
            sb.Append("  alarmNotificationTemplateId: ").Append(AlarmNotificationTemplateId).Append("\n");
            sb.Append("  alarmNotificationTemplateName: ").Append(AlarmNotificationTemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NoticeTypeNotificationTemplateList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NoticeTypeNotificationTemplateList input)
        {
            if (input == null) return false;
            if (this.NoticeType != input.NoticeType) return false;
            if (this.AlarmNotificationTemplateId != input.AlarmNotificationTemplateId || (this.AlarmNotificationTemplateId != null && !this.AlarmNotificationTemplateId.Equals(input.AlarmNotificationTemplateId))) return false;
            if (this.AlarmNotificationTemplateName != input.AlarmNotificationTemplateName || (this.AlarmNotificationTemplateName != null && !this.AlarmNotificationTemplateName.Equals(input.AlarmNotificationTemplateName))) return false;

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
                hashCode = hashCode * 59 + this.NoticeType.GetHashCode();
                if (this.AlarmNotificationTemplateId != null) hashCode = hashCode * 59 + this.AlarmNotificationTemplateId.GetHashCode();
                if (this.AlarmNotificationTemplateName != null) hashCode = hashCode * 59 + this.AlarmNotificationTemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
