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
    /// 终端信息。
    /// </summary>
    public class AddDeviceDTO 
    {
        /// <summary>
        /// 投影码生成模式，默认为自动。 - 0：自动(该模式下根据消息上报的IP地址内部控制复杂度。   私网地址配置成简单模式，公网地址配置成复杂模式) - 1：简单 - 2：复杂
        /// </summary>
        /// <value>投影码生成模式，默认为自动。 - 0：自动(该模式下根据消息上报的IP地址内部控制复杂度。   私网地址配置成简单模式，公网地址配置成复杂模式) - 1：简单 - 2：复杂</value>
        [JsonConverter(typeof(EnumClassConverter<PrjCodeModeEnum>))]
        public class PrjCodeModeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly PrjCodeModeEnum NUMBER_0 = new PrjCodeModeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly PrjCodeModeEnum NUMBER_1 = new PrjCodeModeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly PrjCodeModeEnum NUMBER_2 = new PrjCodeModeEnum(2);

            private static readonly Dictionary<int?, PrjCodeModeEnum> StaticFields =
            new Dictionary<int?, PrjCodeModeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public PrjCodeModeEnum()
            {

            }

            public PrjCodeModeEnum(int? value)
            {
                _value = value;
            }

            public static PrjCodeModeEnum FromValue(int? value)
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

                if (this.Equals(obj as PrjCodeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PrjCodeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PrjCodeModeEnum a, PrjCodeModeEnum b)
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

            public static bool operator !=(PrjCodeModeEnum a, PrjCodeModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 终端状态。默认值：0。 * 0：正常 * 1：冻结 
        /// </summary>
        /// <value>终端状态。默认值：0。 * 0：正常 * 1：冻结 </value>
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
        /// 终端名称，可以自定义，建议为具体位置，方便识别。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 终端型号，枚举类型。当前支持TE系列和部分第三方硬件终端，具体的终端类型可以通过[[获取所有终端类型](https://support.huaweicloud.com/api-meeting/meeting_21_0092.html)](tag:hws)[[获取所有终端类型](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0092.html)](tag:hk)接口查询。
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// 终端SN码，仅可包含数字、字母和下划线。
        /// </summary>
        [JsonProperty("sn", NullValueHandling = NullValueHandling.Ignore)]
        public string Sn { get; set; }

        /// <summary>
        /// 投影码生成模式，默认为自动。 - 0：自动(该模式下根据消息上报的IP地址内部控制复杂度。   私网地址配置成简单模式，公网地址配置成复杂模式) - 1：简单 - 2：复杂
        /// </summary>
        [JsonProperty("prjCodeMode", NullValueHandling = NullValueHandling.Ignore)]
        public PrjCodeModeEnum PrjCodeMode { get; set; }
        /// <summary>
        /// 部门编码，默认为根部门。 默认值：1。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 手机号，必须加上国家码，例如中国大陆手机为“+86xxxxxxxxxxx”。当填写手机号时 “country”参数必填。 手机号只允许输入纯数字。 &gt; 手机号或者邮箱至少填写一个。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 邮箱地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 终端描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 终端状态。默认值：0。 * 0：正常 * 1：冻结 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 是否发送邮件和短信通知。 * 0：不发送 * 不填或者其他值就发送
        /// </summary>
        [JsonProperty("sendNotify", NullValueHandling = NullValueHandling.Ignore)]
        public string SendNotify { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDeviceDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  sn: ").Append(Sn).Append("\n");
            sb.Append("  prjCodeMode: ").Append(PrjCodeMode).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sendNotify: ").Append(SendNotify).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDeviceDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDeviceDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.Sn != input.Sn || (this.Sn != null && !this.Sn.Equals(input.Sn))) return false;
            if (this.PrjCodeMode != input.PrjCodeMode) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Status != input.Status) return false;
            if (this.SendNotify != input.SendNotify || (this.SendNotify != null && !this.SendNotify.Equals(input.SendNotify))) return false;

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
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Sn != null) hashCode = hashCode * 59 + this.Sn.GetHashCode();
                hashCode = hashCode * 59 + this.PrjCodeMode.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SendNotify != null) hashCode = hashCode * 59 + this.SendNotify.GetHashCode();
                return hashCode;
            }
        }
    }
}
