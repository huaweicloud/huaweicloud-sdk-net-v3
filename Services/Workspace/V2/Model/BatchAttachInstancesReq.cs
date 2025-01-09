using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 分配用户请求。
    /// </summary>
    public class BatchAttachInstancesReq 
    {

        /// <summary>
        /// 桌面信息列表。
        /// </summary>
        [JsonProperty("desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInstancesDesktopInfo> Desktops { get; set; }

        /// <summary>
        /// 用户信息列表。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInstancesUserInfo> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assign_model", NullValueHandling = NullValueHandling.Ignore)]
        public AssignModelInfo AssignModel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAttachInstancesReq {\n");
            sb.Append("  desktops: ").Append(Desktops).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  assignModel: ").Append(AssignModel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAttachInstancesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAttachInstancesReq input)
        {
            if (input == null) return false;
            if (this.Desktops != input.Desktops || (this.Desktops != null && input.Desktops != null && !this.Desktops.SequenceEqual(input.Desktops))) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;
            if (this.AssignModel != input.AssignModel || (this.AssignModel != null && !this.AssignModel.Equals(input.AssignModel))) return false;

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
                if (this.Desktops != null) hashCode = hashCode * 59 + this.Desktops.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.AssignModel != null) hashCode = hashCode * 59 + this.AssignModel.GetHashCode();
                return hashCode;
            }
        }
    }
}
