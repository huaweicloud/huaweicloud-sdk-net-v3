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
    /// 
    /// </summary>
    public class VisionActiveCodeDTO 
    {

        /// <summary>
        /// 终端类型。 - idea-hub：智能协作大屏 - huawei-vision：智慧屏TV - welink-desktop(iwb)：SmartRooms会议版 - smart-rooms：SmartRooms完整版 
        /// </summary>
        [JsonProperty("devType", NullValueHandling = NullValueHandling.Ignore)]
        public string DevType { get; set; }

        /// <summary>
        /// 部门编码，若不携带则默认根部门。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 终端的名称。
        /// </summary>
        [JsonProperty("devName", NullValueHandling = NullValueHandling.Ignore)]
        public string DevName { get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 号码信息，如果为手机号，必须加上国家码。 例如中国大陆手机+86xxxxxxx，当填写手机号时 “country”参数必填,手机格式必须满足(^$|^[+]?[0-9]+$) 
        /// </summary>
        [JsonProperty("smsNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsNumber { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 邮箱地址。 &gt; 如无中国大陆手机号，则邮箱必填。 
        /// </summary>
        [JsonProperty("emailAddr", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VisionActiveCodeDTO {\n");
            sb.Append("  devType: ").Append(DevType).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  devName: ").Append(DevName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  smsNumber: ").Append(SmsNumber).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  emailAddr: ").Append(EmailAddr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VisionActiveCodeDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VisionActiveCodeDTO input)
        {
            if (input == null) return false;
            if (this.DevType != input.DevType || (this.DevType != null && !this.DevType.Equals(input.DevType))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.DevName != input.DevName || (this.DevName != null && !this.DevName.Equals(input.DevName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SmsNumber != input.SmsNumber || (this.SmsNumber != null && !this.SmsNumber.Equals(input.SmsNumber))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.EmailAddr != input.EmailAddr || (this.EmailAddr != null && !this.EmailAddr.Equals(input.EmailAddr))) return false;

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
                if (this.DevType != null) hashCode = hashCode * 59 + this.DevType.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.DevName != null) hashCode = hashCode * 59 + this.DevName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SmsNumber != null) hashCode = hashCode * 59 + this.SmsNumber.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.EmailAddr != null) hashCode = hashCode * 59 + this.EmailAddr.GetHashCode();
                return hashCode;
            }
        }
    }
}
