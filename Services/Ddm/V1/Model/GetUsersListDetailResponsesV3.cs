using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetUsersListDetailResponsesV3 
    {

        /// <summary>
        /// **参数解释**：  DDM实例账号的名称。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  DDM实例账号的状态。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  DDM实例账号的基础权限。  **取值范围**：  取值为：CREATE、DROP、ALTER、INDEX、INSERT、DELETE、UPDATE、SELECT
        /// </summary>
        [JsonProperty("base_authority", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BaseAuthority { get; set; }

        /// <summary>
        /// **参数解释**：  DDM实例账号密码的有效期。  **取值范围**：  取值范围为0-65535的整数，单位为天。  0与空表示密码永不过期。
        /// </summary>
        [JsonProperty("password_lifetime", NullValueHandling = NullValueHandling.Ignore)]
        public long? PasswordLifetime { get; set; }

        /// <summary>
        /// **参数解释**：  DDM实例账号密码最近一次的修改时间。  格式为yyyy-mm-ddThh:mm:ssZ。其中，T指定某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("password_last_changed", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordLastChanged { get; set; }

        /// <summary>
        /// **参数解释**：  账号的描述信息。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：  DDM实例账号的创建时间。  格式为yyyy-mm-ddThh:mm:ssZ。其中，T指定某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// **参数解释**：  关联的逻辑库集合。账号只对已关联的逻辑库有访问权限。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetUsersListdatabaseV3> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUsersListDetailResponsesV3 {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  baseAuthority: ").Append(BaseAuthority).Append("\n");
            sb.Append("  passwordLifetime: ").Append(PasswordLifetime).Append("\n");
            sb.Append("  passwordLastChanged: ").Append(PasswordLastChanged).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetUsersListDetailResponsesV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetUsersListDetailResponsesV3 input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BaseAuthority != input.BaseAuthority || (this.BaseAuthority != null && input.BaseAuthority != null && !this.BaseAuthority.SequenceEqual(input.BaseAuthority))) return false;
            if (this.PasswordLifetime != input.PasswordLifetime || (this.PasswordLifetime != null && !this.PasswordLifetime.Equals(input.PasswordLifetime))) return false;
            if (this.PasswordLastChanged != input.PasswordLastChanged || (this.PasswordLastChanged != null && !this.PasswordLastChanged.Equals(input.PasswordLastChanged))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BaseAuthority != null) hashCode = hashCode * 59 + this.BaseAuthority.GetHashCode();
                if (this.PasswordLifetime != null) hashCode = hashCode * 59 + this.PasswordLifetime.GetHashCode();
                if (this.PasswordLastChanged != null) hashCode = hashCode * 59 + this.PasswordLastChanged.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
