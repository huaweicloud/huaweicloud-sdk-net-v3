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
    /// This is a auto query response Object
    /// </summary>
    public class GetUsersListDetailResponses 
    {

        /// <summary>
        /// DDM实例帐号名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// DDM实例帐号状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// DDM实例帐号的基础权限。  取值为：CREATE、DROP、ALTER、INDEX、INSERT、DELETE、UPDATE、SELECT
        /// </summary>
        [JsonProperty("base_authority", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BaseAuthority { get; set; }

        /// <summary>
        /// DDM实例账号的密码修改时间，UNIX时间戳格式。
        /// </summary>
        [JsonProperty("password_last_changed", NullValueHandling = NullValueHandling.Ignore)]
        public long? PasswordLastChanged { get; set; }

        /// <summary>
        /// DDM实例帐号的扩展权限。2021年8月开始不支持该字段，9月会去掉该字段。  取值为：fulltableDelete、fulltableSelect、fulltableUpdate
        /// </summary>
        [JsonProperty("extend_authority", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtendAuthority { get; set; }

        /// <summary>
        /// DDM实例帐号的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// DDM实例帐号的创建时间，UNIX时间戳格式。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; set; }

        /// <summary>
        /// 关联的逻辑库的集合。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetUsersListdatabase> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUsersListDetailResponses {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  baseAuthority: ").Append(BaseAuthority).Append("\n");
            sb.Append("  passwordLastChanged: ").Append(PasswordLastChanged).Append("\n");
            sb.Append("  extendAuthority: ").Append(ExtendAuthority).Append("\n");
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
            return this.Equals(input as GetUsersListDetailResponses);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetUsersListDetailResponses input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BaseAuthority != input.BaseAuthority || (this.BaseAuthority != null && input.BaseAuthority != null && !this.BaseAuthority.SequenceEqual(input.BaseAuthority))) return false;
            if (this.PasswordLastChanged != input.PasswordLastChanged || (this.PasswordLastChanged != null && !this.PasswordLastChanged.Equals(input.PasswordLastChanged))) return false;
            if (this.ExtendAuthority != input.ExtendAuthority || (this.ExtendAuthority != null && input.ExtendAuthority != null && !this.ExtendAuthority.SequenceEqual(input.ExtendAuthority))) return false;
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
                if (this.PasswordLastChanged != null) hashCode = hashCode * 59 + this.PasswordLastChanged.GetHashCode();
                if (this.ExtendAuthority != null) hashCode = hashCode * 59 + this.ExtendAuthority.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
