using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 移动应用至指定分组请求体
    /// </summary>
    public class MoveAppToGroupRequestBody 
    {

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 应用id列表
        /// </summary>
        [JsonProperty("application_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApplicationIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveAppToGroupRequestBody {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  applicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MoveAppToGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MoveAppToGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.ApplicationIds != input.ApplicationIds || (this.ApplicationIds != null && input.ApplicationIds != null && !this.ApplicationIds.SequenceEqual(input.ApplicationIds))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ApplicationIds != null) hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
