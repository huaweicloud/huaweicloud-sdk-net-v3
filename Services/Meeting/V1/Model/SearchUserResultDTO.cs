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
    /// 分页查询企业用户信息。
    /// </summary>
    public class SearchUserResultDTO 
    {

        /// <summary>
        /// 用户UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 华为云会议帐号。
        /// </summary>
        [JsonProperty("userAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAccount { get; set; }

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 英文名称。
        /// </summary>
        [JsonProperty("englishName", NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishName { get; set; }

        /// <summary>
        /// 联系电话。
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
        /// 个人会议ID。
        /// </summary>
        [JsonProperty("vmrId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrId { get; set; }

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 部门完整名称。
        /// </summary>
        [JsonProperty("deptNamePath", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptNamePath { get; set; }

        /// <summary>
        /// 用户类型。 * 2：普通用户 * 12：智慧屏用户 * 13：IdeaHub用户 * 14：SmartRooms用户
        /// </summary>
        [JsonProperty("userType", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserType { get; set; }

        /// <summary>
        /// 管理员类型。 - 0：默认（超级）管理员 - 1：普通管理员 - 2：非管理员（即为普通企业成员，UserType是2时有效）
        /// </summary>
        [JsonProperty("adminType", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdminType { get; set; }

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
        /// 用户状态。 * 0：正常 * 1：停用 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 通讯录排序等级，序号越低优先级越高。
        /// </summary>
        [JsonProperty("sortLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortLevel { get; set; }

        /// <summary>
        /// 是否隐藏手机号码。
        /// </summary>
        [JsonProperty("hidePhone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HidePhone { get; set; }

        /// <summary>
        /// 第三方User ID。
        /// </summary>
        [JsonProperty("thirdAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdAccount { get; set; }

        /// <summary>
        /// 智慧屏帐号。
        /// </summary>
        [JsonProperty("visionAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string VisionAccount { get; set; }

        /// <summary>
        /// 许可证。 * 0：商用 * 1：免费试用 
        /// </summary>
        [JsonProperty("license", NullValueHandling = NullValueHandling.Ignore)]
        public int? License { get; set; }

        /// <summary>
        /// 激活时间，utc时间戳。
        /// </summary>
        [JsonProperty("activeTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveTime { get; set; }

        /// <summary>
        /// 激活码到期时间,utc时间戳。
        /// </summary>
        [JsonProperty("activeCodeExpireTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveCodeExpireTime { get; set; }

        /// <summary>
        /// 已激活的终端到期时间,utc时间戳。
        /// </summary>
        [JsonProperty("expireTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 激活码。
        /// </summary>
        [JsonProperty("activeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchUserResultDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userAccount: ").Append(UserAccount).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  englishName: ").Append(EnglishName).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  vmrId: ").Append(VmrId).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  deptNamePath: ").Append(DeptNamePath).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  adminType: ").Append(AdminType).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sortLevel: ").Append(SortLevel).Append("\n");
            sb.Append("  hidePhone: ").Append(HidePhone).Append("\n");
            sb.Append("  thirdAccount: ").Append(ThirdAccount).Append("\n");
            sb.Append("  visionAccount: ").Append(VisionAccount).Append("\n");
            sb.Append("  license: ").Append(License).Append("\n");
            sb.Append("  activeTime: ").Append(ActiveTime).Append("\n");
            sb.Append("  activeCodeExpireTime: ").Append(ActiveCodeExpireTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  activeCode: ").Append(ActiveCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchUserResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchUserResultDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserAccount != input.UserAccount || (this.UserAccount != null && !this.UserAccount.Equals(input.UserAccount))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnglishName != input.EnglishName || (this.EnglishName != null && !this.EnglishName.Equals(input.EnglishName))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.VmrId != input.VmrId || (this.VmrId != null && !this.VmrId.Equals(input.VmrId))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.DeptNamePath != input.DeptNamePath || (this.DeptNamePath != null && !this.DeptNamePath.Equals(input.DeptNamePath))) return false;
            if (this.UserType != input.UserType || (this.UserType != null && !this.UserType.Equals(input.UserType))) return false;
            if (this.AdminType != input.AdminType || (this.AdminType != null && !this.AdminType.Equals(input.AdminType))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SortLevel != input.SortLevel || (this.SortLevel != null && !this.SortLevel.Equals(input.SortLevel))) return false;
            if (this.HidePhone != input.HidePhone || (this.HidePhone != null && !this.HidePhone.Equals(input.HidePhone))) return false;
            if (this.ThirdAccount != input.ThirdAccount || (this.ThirdAccount != null && !this.ThirdAccount.Equals(input.ThirdAccount))) return false;
            if (this.VisionAccount != input.VisionAccount || (this.VisionAccount != null && !this.VisionAccount.Equals(input.VisionAccount))) return false;
            if (this.License != input.License || (this.License != null && !this.License.Equals(input.License))) return false;
            if (this.ActiveTime != input.ActiveTime || (this.ActiveTime != null && !this.ActiveTime.Equals(input.ActiveTime))) return false;
            if (this.ActiveCodeExpireTime != input.ActiveCodeExpireTime || (this.ActiveCodeExpireTime != null && !this.ActiveCodeExpireTime.Equals(input.ActiveCodeExpireTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ActiveCode != input.ActiveCode || (this.ActiveCode != null && !this.ActiveCode.Equals(input.ActiveCode))) return false;

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
                if (this.UserAccount != null) hashCode = hashCode * 59 + this.UserAccount.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnglishName != null) hashCode = hashCode * 59 + this.EnglishName.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.VmrId != null) hashCode = hashCode * 59 + this.VmrId.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.DeptNamePath != null) hashCode = hashCode * 59 + this.DeptNamePath.GetHashCode();
                if (this.UserType != null) hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.AdminType != null) hashCode = hashCode * 59 + this.AdminType.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SortLevel != null) hashCode = hashCode * 59 + this.SortLevel.GetHashCode();
                if (this.HidePhone != null) hashCode = hashCode * 59 + this.HidePhone.GetHashCode();
                if (this.ThirdAccount != null) hashCode = hashCode * 59 + this.ThirdAccount.GetHashCode();
                if (this.VisionAccount != null) hashCode = hashCode * 59 + this.VisionAccount.GetHashCode();
                if (this.License != null) hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.ActiveTime != null) hashCode = hashCode * 59 + this.ActiveTime.GetHashCode();
                if (this.ActiveCodeExpireTime != null) hashCode = hashCode * 59 + this.ActiveCodeExpireTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ActiveCode != null) hashCode = hashCode * 59 + this.ActiveCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
