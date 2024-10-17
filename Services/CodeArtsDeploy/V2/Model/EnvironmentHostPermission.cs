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
    /// 环境下主机权限详情
    /// </summary>
    public class EnvironmentHostPermission 
    {

        /// <summary>
        /// 是否有删除权限
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否有部署权限
        /// </summary>
        [JsonProperty("can_deploy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDeploy { get; set; }

        /// <summary>
        /// 是否有编辑权限
        /// </summary>
        [JsonProperty("can_edit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// 是否有权限管理权限
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// 是否有查看权限
        /// </summary>
        [JsonProperty("can_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanView { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentHostPermission {\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canDeploy: ").Append(CanDeploy).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvironmentHostPermission);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvironmentHostPermission input)
        {
            if (input == null) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanDeploy != input.CanDeploy || (this.CanDeploy != null && !this.CanDeploy.Equals(input.CanDeploy))) return false;
            if (this.CanEdit != input.CanEdit || (this.CanEdit != null && !this.CanEdit.Equals(input.CanEdit))) return false;
            if (this.CanManage != input.CanManage || (this.CanManage != null && !this.CanManage.Equals(input.CanManage))) return false;
            if (this.CanView != input.CanView || (this.CanView != null && !this.CanView.Equals(input.CanView))) return false;

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
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanDeploy != null) hashCode = hashCode * 59 + this.CanDeploy.GetHashCode();
                if (this.CanEdit != null) hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanManage != null) hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CanView != null) hashCode = hashCode * 59 + this.CanView.GetHashCode();
                return hashCode;
            }
        }
    }
}
