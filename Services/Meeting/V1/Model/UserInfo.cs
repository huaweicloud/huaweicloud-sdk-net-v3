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
    /// 用户鉴权信息。
    /// </summary>
    public class UserInfo 
    {

        /// <summary>
        /// 用户UUID。
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 华为云会议帐号。
        /// </summary>
        [JsonProperty("ucloginAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string UcloginAccount { get; set; }

        /// <summary>
        /// 用户关联的SIP号码。 
        /// </summary>
        [JsonProperty("serviceAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// 号码对应的HA1。
        /// </summary>
        [JsonProperty("numberHA1", NullValueHandling = NullValueHandling.Ignore)]
        public string NumberHA1 { get; set; }

        /// <summary>
        /// 用户别名。
        /// </summary>
        [JsonProperty("alias1", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias1 { get; set; }

        /// <summary>
        /// 用户归属的企业ID。
        /// </summary>
        [JsonProperty("companyId", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyId { get; set; }

        /// <summary>
        /// 用户所在企业归属的SP ID。
        /// </summary>
        [JsonProperty("spId", NullValueHandling = NullValueHandling.Ignore)]
        public string SpId { get; set; }

        /// <summary>
        /// 企业域名。
        /// </summary>
        [JsonProperty("companyDomain", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyDomain { get; set; }

        /// <summary>
        /// 本地鉴权。
        /// </summary>
        [JsonProperty("realm", NullValueHandling = NullValueHandling.Ignore)]
        public string Realm { get; set; }

        /// <summary>
        /// 用户类型。 * 1：SP管理用户 * 2：企业用户 * 3：免费注册用户 * 10：企业设备用户 * 11：匿名用户 * 12：智慧屏用户 * 13：IdeaHub用户 * 14：电子白板（SmartRooms）用户 
        /// </summary>
        [JsonProperty("userType", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserType { get; set; }

        /// <summary>
        /// 管理员类型。 * 0：默认管理员 * 1：普通管理员 * 2：非管理员，即普通企业成员，userType为2时有效 
        /// </summary>
        [JsonProperty("adminType", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdminType { get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户英文名称。
        /// </summary>
        [JsonProperty("nameEn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 标识是否绑定手机。
        /// </summary>
        [JsonProperty("isBindPhone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBindPhone { get; set; }

        /// <summary>
        /// 标识是否是免费试用用户。
        /// </summary>
        [JsonProperty("freeUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreeUser { get; set; }

        /// <summary>
        /// 第三方的用户帐号。
        /// </summary>
        [JsonProperty("thirdAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdAccount { get; set; }

        /// <summary>
        /// 智慧屏设备ID。
        /// </summary>
        [JsonProperty("visionAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string VisionAccount { get; set; }

        /// <summary>
        /// 头像链接。
        /// </summary>
        [JsonProperty("headPictureUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadPictureUrl { get; set; }

        /// <summary>
        /// 机机密码，用于智慧屏登录。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 用户状态。 * 0：正常 * 1：停用 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 付费用户机机帐号，用于智慧屏登录。
        /// </summary>
        [JsonProperty("paidAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidAccount { get; set; }

        /// <summary>
        /// 付费用户机机密码，用于智慧屏登录。
        /// </summary>
        [JsonProperty("paidPassword", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidPassword { get; set; }

        /// <summary>
        /// 标识是否是WeLink用户。
        /// </summary>
        [JsonProperty("weLinkUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WeLinkUser { get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("appId", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// tr069帐号。
        /// </summary>
        [JsonProperty("tr069Account", NullValueHandling = NullValueHandling.Ignore)]
        public string Tr069Account { get; set; }

        /// <summary>
        /// 企业类型。 * 0：旗舰版 * 5：免费版 * 6：标准版 
        /// </summary>
        [JsonProperty("corpType", NullValueHandling = NullValueHandling.Ignore)]
        public int? CorpType { get; set; }

        /// <summary>
        /// 华为云帐号ID。
        /// </summary>
        [JsonProperty("cloudUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudUserId { get; set; }

        /// <summary>
        /// 标识是否是灰度用户。
        /// </summary>
        [JsonProperty("grayUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GrayUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  ucloginAccount: ").Append(UcloginAccount).Append("\n");
            sb.Append("  serviceAccount: ").Append(ServiceAccount).Append("\n");
            sb.Append("  numberHA1: ").Append(NumberHA1).Append("\n");
            sb.Append("  alias1: ").Append(Alias1).Append("\n");
            sb.Append("  companyId: ").Append(CompanyId).Append("\n");
            sb.Append("  spId: ").Append(SpId).Append("\n");
            sb.Append("  companyDomain: ").Append(CompanyDomain).Append("\n");
            sb.Append("  realm: ").Append(Realm).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  adminType: ").Append(AdminType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  isBindPhone: ").Append(IsBindPhone).Append("\n");
            sb.Append("  freeUser: ").Append(FreeUser).Append("\n");
            sb.Append("  thirdAccount: ").Append(ThirdAccount).Append("\n");
            sb.Append("  visionAccount: ").Append(VisionAccount).Append("\n");
            sb.Append("  headPictureUrl: ").Append(HeadPictureUrl).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  paidAccount: ").Append(PaidAccount).Append("\n");
            sb.Append("  paidPassword: ").Append(PaidPassword).Append("\n");
            sb.Append("  weLinkUser: ").Append(WeLinkUser).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  tr069Account: ").Append(Tr069Account).Append("\n");
            sb.Append("  corpType: ").Append(CorpType).Append("\n");
            sb.Append("  cloudUserId: ").Append(CloudUserId).Append("\n");
            sb.Append("  grayUser: ").Append(GrayUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserInfo input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UcloginAccount != input.UcloginAccount || (this.UcloginAccount != null && !this.UcloginAccount.Equals(input.UcloginAccount))) return false;
            if (this.ServiceAccount != input.ServiceAccount || (this.ServiceAccount != null && !this.ServiceAccount.Equals(input.ServiceAccount))) return false;
            if (this.NumberHA1 != input.NumberHA1 || (this.NumberHA1 != null && !this.NumberHA1.Equals(input.NumberHA1))) return false;
            if (this.Alias1 != input.Alias1 || (this.Alias1 != null && !this.Alias1.Equals(input.Alias1))) return false;
            if (this.CompanyId != input.CompanyId || (this.CompanyId != null && !this.CompanyId.Equals(input.CompanyId))) return false;
            if (this.SpId != input.SpId || (this.SpId != null && !this.SpId.Equals(input.SpId))) return false;
            if (this.CompanyDomain != input.CompanyDomain || (this.CompanyDomain != null && !this.CompanyDomain.Equals(input.CompanyDomain))) return false;
            if (this.Realm != input.Realm || (this.Realm != null && !this.Realm.Equals(input.Realm))) return false;
            if (this.UserType != input.UserType || (this.UserType != null && !this.UserType.Equals(input.UserType))) return false;
            if (this.AdminType != input.AdminType || (this.AdminType != null && !this.AdminType.Equals(input.AdminType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.IsBindPhone != input.IsBindPhone || (this.IsBindPhone != null && !this.IsBindPhone.Equals(input.IsBindPhone))) return false;
            if (this.FreeUser != input.FreeUser || (this.FreeUser != null && !this.FreeUser.Equals(input.FreeUser))) return false;
            if (this.ThirdAccount != input.ThirdAccount || (this.ThirdAccount != null && !this.ThirdAccount.Equals(input.ThirdAccount))) return false;
            if (this.VisionAccount != input.VisionAccount || (this.VisionAccount != null && !this.VisionAccount.Equals(input.VisionAccount))) return false;
            if (this.HeadPictureUrl != input.HeadPictureUrl || (this.HeadPictureUrl != null && !this.HeadPictureUrl.Equals(input.HeadPictureUrl))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PaidAccount != input.PaidAccount || (this.PaidAccount != null && !this.PaidAccount.Equals(input.PaidAccount))) return false;
            if (this.PaidPassword != input.PaidPassword || (this.PaidPassword != null && !this.PaidPassword.Equals(input.PaidPassword))) return false;
            if (this.WeLinkUser != input.WeLinkUser || (this.WeLinkUser != null && !this.WeLinkUser.Equals(input.WeLinkUser))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.Tr069Account != input.Tr069Account || (this.Tr069Account != null && !this.Tr069Account.Equals(input.Tr069Account))) return false;
            if (this.CorpType != input.CorpType || (this.CorpType != null && !this.CorpType.Equals(input.CorpType))) return false;
            if (this.CloudUserId != input.CloudUserId || (this.CloudUserId != null && !this.CloudUserId.Equals(input.CloudUserId))) return false;
            if (this.GrayUser != input.GrayUser || (this.GrayUser != null && !this.GrayUser.Equals(input.GrayUser))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UcloginAccount != null) hashCode = hashCode * 59 + this.UcloginAccount.GetHashCode();
                if (this.ServiceAccount != null) hashCode = hashCode * 59 + this.ServiceAccount.GetHashCode();
                if (this.NumberHA1 != null) hashCode = hashCode * 59 + this.NumberHA1.GetHashCode();
                if (this.Alias1 != null) hashCode = hashCode * 59 + this.Alias1.GetHashCode();
                if (this.CompanyId != null) hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.SpId != null) hashCode = hashCode * 59 + this.SpId.GetHashCode();
                if (this.CompanyDomain != null) hashCode = hashCode * 59 + this.CompanyDomain.GetHashCode();
                if (this.Realm != null) hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.UserType != null) hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.AdminType != null) hashCode = hashCode * 59 + this.AdminType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.IsBindPhone != null) hashCode = hashCode * 59 + this.IsBindPhone.GetHashCode();
                if (this.FreeUser != null) hashCode = hashCode * 59 + this.FreeUser.GetHashCode();
                if (this.ThirdAccount != null) hashCode = hashCode * 59 + this.ThirdAccount.GetHashCode();
                if (this.VisionAccount != null) hashCode = hashCode * 59 + this.VisionAccount.GetHashCode();
                if (this.HeadPictureUrl != null) hashCode = hashCode * 59 + this.HeadPictureUrl.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PaidAccount != null) hashCode = hashCode * 59 + this.PaidAccount.GetHashCode();
                if (this.PaidPassword != null) hashCode = hashCode * 59 + this.PaidPassword.GetHashCode();
                if (this.WeLinkUser != null) hashCode = hashCode * 59 + this.WeLinkUser.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Tr069Account != null) hashCode = hashCode * 59 + this.Tr069Account.GetHashCode();
                if (this.CorpType != null) hashCode = hashCode * 59 + this.CorpType.GetHashCode();
                if (this.CloudUserId != null) hashCode = hashCode * 59 + this.CloudUserId.GetHashCode();
                if (this.GrayUser != null) hashCode = hashCode * 59 + this.GrayUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
