using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// current user group permission
    /// </summary>
    public class UserGroupPermissionDto 
    {

        /// <summary>
        /// **参数解释：** 是否可以创建代码组。
        /// </summary>
        [JsonProperty("can_create_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCreateGroup { get; set; }

        /// <summary>
        /// **参数解释：** 是否可以创建仓库。
        /// </summary>
        [JsonProperty("can_craete_project", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCraeteProject { get; set; }

        /// <summary>
        /// **参数解释：** 是否可以设置代码组。
        /// </summary>
        [JsonProperty("can_set_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSetGroup { get; set; }

        /// <summary>
        /// **参数解释：** 代码组id。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; }

        /// <summary>
        /// **参数解释：** 可见性, private public。
        /// </summary>
        [JsonProperty("group_visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupVisibility { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserGroupPermissionDto {\n");
            sb.Append("  canCreateGroup: ").Append(CanCreateGroup).Append("\n");
            sb.Append("  canCraeteProject: ").Append(CanCraeteProject).Append("\n");
            sb.Append("  canSetGroup: ").Append(CanSetGroup).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupVisibility: ").Append(GroupVisibility).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserGroupPermissionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserGroupPermissionDto input)
        {
            if (input == null) return false;
            if (this.CanCreateGroup != input.CanCreateGroup || (this.CanCreateGroup != null && !this.CanCreateGroup.Equals(input.CanCreateGroup))) return false;
            if (this.CanCraeteProject != input.CanCraeteProject || (this.CanCraeteProject != null && !this.CanCraeteProject.Equals(input.CanCraeteProject))) return false;
            if (this.CanSetGroup != input.CanSetGroup || (this.CanSetGroup != null && !this.CanSetGroup.Equals(input.CanSetGroup))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.GroupVisibility != input.GroupVisibility || (this.GroupVisibility != null && !this.GroupVisibility.Equals(input.GroupVisibility))) return false;

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
                if (this.CanCreateGroup != null) hashCode = hashCode * 59 + this.CanCreateGroup.GetHashCode();
                if (this.CanCraeteProject != null) hashCode = hashCode * 59 + this.CanCraeteProject.GetHashCode();
                if (this.CanSetGroup != null) hashCode = hashCode * 59 + this.CanSetGroup.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupVisibility != null) hashCode = hashCode * 59 + this.GroupVisibility.GetHashCode();
                return hashCode;
            }
        }
    }
}
