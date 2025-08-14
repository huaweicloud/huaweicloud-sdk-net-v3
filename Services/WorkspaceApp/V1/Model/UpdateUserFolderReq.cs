using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 修改个人文件夹。
    /// </summary>
    public class UpdateUserFolderReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("update_user_assignment_info", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateUserAssignmentInfo UpdateUserAssignmentInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserFolderReq {\n");
            sb.Append("  updateUserAssignmentInfo: ").Append(UpdateUserAssignmentInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserFolderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserFolderReq input)
        {
            if (input == null) return false;
            if (this.UpdateUserAssignmentInfo != input.UpdateUserAssignmentInfo || (this.UpdateUserAssignmentInfo != null && !this.UpdateUserAssignmentInfo.Equals(input.UpdateUserAssignmentInfo))) return false;

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
                if (this.UpdateUserAssignmentInfo != null) hashCode = hashCode * 59 + this.UpdateUserAssignmentInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
