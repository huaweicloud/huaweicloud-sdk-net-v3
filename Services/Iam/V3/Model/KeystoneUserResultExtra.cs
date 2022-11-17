using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KeystoneUserResultExtra 
    {

        /// <summary>
        /// IAM用户描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// IAM用户密码状态。true：需要修改密码，false：正常。
        /// </summary>
        [JsonProperty("pwd_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PwdStatus { get; set; }

        /// <summary>
        /// IAM用户退出系统前，在控制台最后访问的项目ID。
        /// </summary>
        [JsonProperty("last_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneUserResultExtra {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  pwdStatus: ").Append(PwdStatus).Append("\n");
            sb.Append("  lastProjectId: ").Append(LastProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneUserResultExtra);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneUserResultExtra input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PwdStatus == input.PwdStatus ||
                    (this.PwdStatus != null &&
                    this.PwdStatus.Equals(input.PwdStatus))
                ) && 
                (
                    this.LastProjectId == input.LastProjectId ||
                    (this.LastProjectId != null &&
                    this.LastProjectId.Equals(input.LastProjectId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PwdStatus != null)
                    hashCode = hashCode * 59 + this.PwdStatus.GetHashCode();
                if (this.LastProjectId != null)
                    hashCode = hashCode * 59 + this.LastProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
