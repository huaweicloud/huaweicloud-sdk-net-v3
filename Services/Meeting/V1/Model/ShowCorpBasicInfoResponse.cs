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
    public class ShowCorpBasicInfoResponse : SdkResponse
    {

        /// <summary>
        /// 企业id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 企业名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 企业所在地。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 管理员名称。
        /// </summary>
        [JsonProperty("adminName", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminName { get; set; }

        /// <summary>
        /// 管理员的华为云会议帐号。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 管理员手机。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 管理员邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 是否通过短信形式发送会议通知。
        /// </summary>
        [JsonProperty("enableSMS", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSMS { get; set; }

        /// <summary>
        /// 是否开启云盘。
        /// </summary>
        [JsonProperty("enableCloudDisk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCloudDisk { get; set; }

        /// <summary>
        /// 是否具有pstn功能。
        /// </summary>
        [JsonProperty("enablePstn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePstn { get; set; }

        /// <summary>
        /// 是否支持自动开户。
        /// </summary>
        [JsonProperty("autoUserCreate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUserCreate { get; set; }

        /// <summary>
        /// 企业类型。 * 0：旗舰版 * 5：免费版 * 6：标准版 
        /// </summary>
        [JsonProperty("corpType", NullValueHandling = NullValueHandling.Ignore)]
        public int? CorpType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCorpBasicInfoResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  adminName: ").Append(AdminName).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  enableSMS: ").Append(EnableSMS).Append("\n");
            sb.Append("  enableCloudDisk: ").Append(EnableCloudDisk).Append("\n");
            sb.Append("  enablePstn: ").Append(EnablePstn).Append("\n");
            sb.Append("  autoUserCreate: ").Append(AutoUserCreate).Append("\n");
            sb.Append("  corpType: ").Append(CorpType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCorpBasicInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCorpBasicInfoResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AdminName != input.AdminName || (this.AdminName != null && !this.AdminName.Equals(input.AdminName))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.EnableSMS != input.EnableSMS || (this.EnableSMS != null && !this.EnableSMS.Equals(input.EnableSMS))) return false;
            if (this.EnableCloudDisk != input.EnableCloudDisk || (this.EnableCloudDisk != null && !this.EnableCloudDisk.Equals(input.EnableCloudDisk))) return false;
            if (this.EnablePstn != input.EnablePstn || (this.EnablePstn != null && !this.EnablePstn.Equals(input.EnablePstn))) return false;
            if (this.AutoUserCreate != input.AutoUserCreate || (this.AutoUserCreate != null && !this.AutoUserCreate.Equals(input.AutoUserCreate))) return false;
            if (this.CorpType != input.CorpType || (this.CorpType != null && !this.CorpType.Equals(input.CorpType))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AdminName != null) hashCode = hashCode * 59 + this.AdminName.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EnableSMS != null) hashCode = hashCode * 59 + this.EnableSMS.GetHashCode();
                if (this.EnableCloudDisk != null) hashCode = hashCode * 59 + this.EnableCloudDisk.GetHashCode();
                if (this.EnablePstn != null) hashCode = hashCode * 59 + this.EnablePstn.GetHashCode();
                if (this.AutoUserCreate != null) hashCode = hashCode * 59 + this.AutoUserCreate.GetHashCode();
                if (this.CorpType != null) hashCode = hashCode * 59 + this.CorpType.GetHashCode();
                return hashCode;
            }
        }
    }
}
