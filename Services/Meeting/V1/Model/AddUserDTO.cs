using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 用户信息。
    /// </summary>
    public class AddUserDTO 
    {
        /// <summary>
        /// 用户状态。默认值：0 * 0：正常 * 1：停用
        /// </summary>
        /// <value>用户状态。默认值：0 * 0：正常 * 1：停用</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StatusEnum NUMBER_1 = new StatusEnum(1);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public StatusEnum()
            {

            }

            public StatusEnum(int? value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 企业用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 企业用户的英文名称。
        /// </summary>
        [JsonProperty("englishName", NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishName { get; set; }

        /// <summary>
        /// 企业用户帐号，若携带则以携带为准，否则后台自动生成。帐号整系统唯一。 帐号只能包含大小写字母、数字、_、-、.、@符号，不能为纯数字和@后面带.号。 &gt; 帐号/密码鉴权方式时需要填写。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 第三方User ID。 &gt; App ID鉴权方式时需要填写。第三方User ID需要企业内唯一。
        /// </summary>
        [JsonProperty("thirdAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdAccount { get; set; }

        /// <summary>
        /// 手机号，必须加上国家码。 例如中国大陆手机+86xxxxxxx。当填写手机号时 “country”参数必填。 手机号只允许输入纯数字。 说明：手机号或者邮箱至少填写一个
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 企业用户帐号的密码。若携带则以实际携带为准，否则后台默认生成，密码必须满足： 1、8-32位 2、不能和帐号的正序和倒序一致 3、至少包含两种字符类型：小写字母、大写字母、数字、特殊字符（&#x60; ~ ! @ # $ % ^ &amp; * ( ) - _ &#x3D; + | [ { } ] ; : \&quot; ,’ &lt; . &gt; / ?）
        /// </summary>
        [JsonProperty("pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string Pwd { get; set; }

        /// <summary>
        /// 邮箱地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 部门编码，若不携带则默认根部门。 默认值：1
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 签名。
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// 职位。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 用户状态。默认值：0 * 0：正常 * 1：停用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public UserFunctionDTO Function { get; set; }

        /// <summary>
        /// 是否发送开户的邮件和短信通知。 - 0 不发送 - 不填或者其他值就发送, 默认发送
        /// </summary>
        [JsonProperty("sendNotify", NullValueHandling = NullValueHandling.Ignore)]
        public string SendNotify { get; set; }

        /// <summary>
        /// 通讯录排序等级，序号越低优先级越高。 默认值：10000
        /// </summary>
        [JsonProperty("sortLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortLevel { get; set; }

        /// <summary>
        /// 是否隐藏手机号码。默认值：false。 * true：在通讯录和会议中不显示手机号码 * false：在通讯录和会议中显示手机号码 
        /// </summary>
        [JsonProperty("hidePhone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HidePhone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddUserDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  englishName: ").Append(EnglishName).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  thirdAccount: ").Append(ThirdAccount).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  pwd: ").Append(Pwd).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  function: ").Append(Function).Append("\n");
            sb.Append("  sendNotify: ").Append(SendNotify).Append("\n");
            sb.Append("  sortLevel: ").Append(SortLevel).Append("\n");
            sb.Append("  hidePhone: ").Append(HidePhone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddUserDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddUserDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnglishName != input.EnglishName || (this.EnglishName != null && !this.EnglishName.Equals(input.EnglishName))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.ThirdAccount != input.ThirdAccount || (this.ThirdAccount != null && !this.ThirdAccount.Equals(input.ThirdAccount))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Pwd != input.Pwd || (this.Pwd != null && !this.Pwd.Equals(input.Pwd))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.Status != input.Status) return false;
            if (this.Function != input.Function || (this.Function != null && !this.Function.Equals(input.Function))) return false;
            if (this.SendNotify != input.SendNotify || (this.SendNotify != null && !this.SendNotify.Equals(input.SendNotify))) return false;
            if (this.SortLevel != input.SortLevel || (this.SortLevel != null && !this.SortLevel.Equals(input.SortLevel))) return false;
            if (this.HidePhone != input.HidePhone || (this.HidePhone != null && !this.HidePhone.Equals(input.HidePhone))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnglishName != null) hashCode = hashCode * 59 + this.EnglishName.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.ThirdAccount != null) hashCode = hashCode * 59 + this.ThirdAccount.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Pwd != null) hashCode = hashCode * 59 + this.Pwd.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Function != null) hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.SendNotify != null) hashCode = hashCode * 59 + this.SendNotify.GetHashCode();
                if (this.SortLevel != null) hashCode = hashCode * 59 + this.SortLevel.GetHashCode();
                if (this.HidePhone != null) hashCode = hashCode * 59 + this.HidePhone.GetHashCode();
                return hashCode;
            }
        }
    }
}
