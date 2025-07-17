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
    public class UserDTO 
    {

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 查询用户详情时, 根据不同情况，响应不同。 * 0： 查询成功且用户信息有变化， 响应会把新的信息都返回回去 * 1 ：查询成功且用户信息没有变化，响应只会返回用户ID * 2 ：用户不存在 * 3 ：无权限查询这个用户 
        /// </summary>
        [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 用户帐号。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 英文名。
        /// </summary>
        [JsonProperty("englishName", NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishName { get; set; }

        /// <summary>
        /// 邮箱地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 用户手机。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 用户部门。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 用户SIP号码。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 用户信息最后更新时间。
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 是否为硬终端。 &gt; 该参数将被废弃，请勿使用。 
        /// </summary>
        [JsonProperty("isHardTerminal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHardTerminal { get; set; }

        /// <summary>
        /// 用户虚拟会议室ID。
        /// </summary>
        [JsonProperty("vmrId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrId { get; set; }

        /// <summary>
        /// 用户签名。
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// 职位。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否隐藏手机号（如果为true，其他人查询该用户时，不会返回该用户的手机号。自己查自己是可见的）
        /// </summary>
        [JsonProperty("hidePhone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HidePhone { get; set; }

        /// <summary>
        /// 类型： * NORMAL_USER&#x3D;普通用户 * HARD_TERMINAL&#x3D;硬终端用户 * WHITE_BOARD&#x3D;第三方白板 * HW_VISION_MEMBER&#x3D;智慧屏 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 部门编码列表。
        /// </summary>
        [JsonProperty("deptCodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeptCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  englishName: ").Append(EnglishName).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  isHardTerminal: ").Append(IsHardTerminal).Append("\n");
            sb.Append("  vmrId: ").Append(VmrId).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  hidePhone: ").Append(HidePhone).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  deptCodes: ").Append(DeptCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnglishName != input.EnglishName || (this.EnglishName != null && !this.EnglishName.Equals(input.EnglishName))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IsHardTerminal != input.IsHardTerminal || (this.IsHardTerminal != null && !this.IsHardTerminal.Equals(input.IsHardTerminal))) return false;
            if (this.VmrId != input.VmrId || (this.VmrId != null && !this.VmrId.Equals(input.VmrId))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.HidePhone != input.HidePhone || (this.HidePhone != null && !this.HidePhone.Equals(input.HidePhone))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DeptCodes != input.DeptCodes || (this.DeptCodes != null && input.DeptCodes != null && !this.DeptCodes.SequenceEqual(input.DeptCodes))) return false;

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
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnglishName != null) hashCode = hashCode * 59 + this.EnglishName.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IsHardTerminal != null) hashCode = hashCode * 59 + this.IsHardTerminal.GetHashCode();
                if (this.VmrId != null) hashCode = hashCode * 59 + this.VmrId.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HidePhone != null) hashCode = hashCode * 59 + this.HidePhone.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeptCodes != null) hashCode = hashCode * 59 + this.DeptCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
