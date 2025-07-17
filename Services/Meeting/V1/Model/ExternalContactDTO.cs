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
    /// 外部联系人信息。
    /// </summary>
    public class ExternalContactDTO 
    {

        /// <summary>
        /// 其他号码。 &gt; * 其他号码必须以国家码作为前缀 &gt; * otherNumber填写时，otherNumberCountry也必须填写 &gt; * 如果要清空手机号配置，则otherNumberCountry和otherNumber都要置为\&quot;\&quot; 
        /// </summary>
        [JsonProperty("otherNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherNumber { get; set; }

        /// <summary>
        /// [[其他号码所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("otherNumberCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherNumberCountry { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 手机号。 &gt; * 手机号必须以国家码作为前缀 &gt; * phone填写时，country也必须填写 &gt; * 如果要清空手机号配置，则country和phone都要置为\&quot;\&quot; 
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 公司名称。
        /// </summary>
        [JsonProperty("corpName", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpName { get; set; }

        /// <summary>
        /// 部门。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 职务。
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// 个人地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// 外部联系人UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 姓名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 外部联系人自定义号码。 &gt; 仅VDC场景下使用。 
        /// </summary>
        [JsonProperty("customNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomNumber { get; set; }

        /// <summary>
        /// 用户信息最后更新时间戳。
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? UpdateTime { get; set; }

        /// <summary>
        /// 外部联系人类型。 * PERSONAL：个人外部联系人 * CORP：企业外部联系人 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactDTO {\n");
            sb.Append("  otherNumber: ").Append(OtherNumber).Append("\n");
            sb.Append("  otherNumberCountry: ").Append(OtherNumberCountry).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  corpName: ").Append(CorpName).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  customNumber: ").Append(CustomNumber).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalContactDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalContactDTO input)
        {
            if (input == null) return false;
            if (this.OtherNumber != input.OtherNumber || (this.OtherNumber != null && !this.OtherNumber.Equals(input.OtherNumber))) return false;
            if (this.OtherNumberCountry != input.OtherNumberCountry || (this.OtherNumberCountry != null && !this.OtherNumberCountry.Equals(input.OtherNumberCountry))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.CorpName != input.CorpName || (this.CorpName != null && !this.CorpName.Equals(input.CorpName))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Remarks != input.Remarks || (this.Remarks != null && !this.Remarks.Equals(input.Remarks))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CustomNumber != input.CustomNumber || (this.CustomNumber != null && !this.CustomNumber.Equals(input.CustomNumber))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.OtherNumber != null) hashCode = hashCode * 59 + this.OtherNumber.GetHashCode();
                if (this.OtherNumberCountry != null) hashCode = hashCode * 59 + this.OtherNumberCountry.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CorpName != null) hashCode = hashCode * 59 + this.CorpName.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Remarks != null) hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CustomNumber != null) hashCode = hashCode * 59 + this.CustomNumber.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
