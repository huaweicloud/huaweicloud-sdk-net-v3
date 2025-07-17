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
    /// Response Object
    /// </summary>
    public class ShowDeviceDetailResponse : SdkResponse
    {

        /// <summary>
        /// 终端名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 终端类型，区分自研和第三方终端。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 终端型号，枚举类型。当前支持TE系列和部分第三方硬件终端，具体的终端类型可以通过[[获取所有终端类型](https://support.huaweicloud.com/api-meeting/meeting_21_0092.html)](tag:hws)[[获取所有终端类型](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0092.html)](tag:hk)接口查询。
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// 终端SN号，仅可包含数字、字母和下划线。
        /// </summary>
        [JsonProperty("sn", NullValueHandling = NullValueHandling.Ignore)]
        public string Sn { get; set; }

        /// <summary>
        /// 硬终端对应的内置帐号。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 终端绑定的号码。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 投影码生成模式。 * 0：自动(该模式下根据消息上报的IP地址内部控制复杂度：私网地址配置成简单模式；公网地址配置成复杂模式) * 1：简单 * 2：复杂 
        /// </summary>
        [JsonProperty("prjCodeMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrjCodeMode { get; set; }

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门名称路径。
        /// </summary>
        [JsonProperty("deptNamePath", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptNamePath { get; set; }

        /// <summary>
        /// 手机号。
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
        /// 终端状态。 * 0、正常 * 1、停用\&quot; 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeviceDetailResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  sn: ").Append(Sn).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  prjCodeMode: ").Append(PrjCodeMode).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  deptNamePath: ").Append(DeptNamePath).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeviceDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeviceDetailResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.Sn != input.Sn || (this.Sn != null && !this.Sn.Equals(input.Sn))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.PrjCodeMode != input.PrjCodeMode || (this.PrjCodeMode != null && !this.PrjCodeMode.Equals(input.PrjCodeMode))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.DeptNamePath != input.DeptNamePath || (this.DeptNamePath != null && !this.DeptNamePath.Equals(input.DeptNamePath))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Sn != null) hashCode = hashCode * 59 + this.Sn.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.PrjCodeMode != null) hashCode = hashCode * 59 + this.PrjCodeMode.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.DeptNamePath != null) hashCode = hashCode * 59 + this.DeptNamePath.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
