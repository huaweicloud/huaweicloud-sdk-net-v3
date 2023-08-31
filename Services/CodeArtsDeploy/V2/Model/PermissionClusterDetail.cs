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
    /// 主机集群相关权限详情类
    /// </summary>
    public class PermissionClusterDetail 
    {

        /// <summary>
        /// 是否有查看权限
        /// </summary>
        [JsonProperty("can_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanView { get; set; }

        /// <summary>
        /// 是否有编辑权限
        /// </summary>
        [JsonProperty("can_edit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// 是否有删除权限
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否有添加主机权限
        /// </summary>
        [JsonProperty("can_add_host", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanAddHost { get; set; }

        /// <summary>
        /// 是否有编辑主机集群权限矩阵的权限
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionClusterDetail {\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canAddHost: ").Append(CanAddHost).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionClusterDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionClusterDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanView == input.CanView ||
                    (this.CanView != null &&
                    this.CanView.Equals(input.CanView))
                ) && 
                (
                    this.CanEdit == input.CanEdit ||
                    (this.CanEdit != null &&
                    this.CanEdit.Equals(input.CanEdit))
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.CanAddHost == input.CanAddHost ||
                    (this.CanAddHost != null &&
                    this.CanAddHost.Equals(input.CanAddHost))
                ) && 
                (
                    this.CanManage == input.CanManage ||
                    (this.CanManage != null &&
                    this.CanManage.Equals(input.CanManage))
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
                if (this.CanView != null)
                    hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanEdit != null)
                    hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanAddHost != null)
                    hashCode = hashCode * 59 + this.CanAddHost.GetHashCode();
                if (this.CanManage != null)
                    hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                return hashCode;
            }
        }
    }
}
