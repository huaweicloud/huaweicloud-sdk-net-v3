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
    /// 主机相关权限详情类
    /// </summary>
    public class PermissionHostDetail 
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
        /// 是否测试主机连通性权限
        /// </summary>
        [JsonProperty("can_connection_test", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanConnectionTest { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionHostDetail {\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canAddHost: ").Append(CanAddHost).Append("\n");
            sb.Append("  canConnectionTest: ").Append(CanConnectionTest).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionHostDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionHostDetail input)
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
                    this.CanConnectionTest == input.CanConnectionTest ||
                    (this.CanConnectionTest != null &&
                    this.CanConnectionTest.Equals(input.CanConnectionTest))
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
                if (this.CanConnectionTest != null)
                    hashCode = hashCode * 59 + this.CanConnectionTest.GetHashCode();
                return hashCode;
            }
        }
    }
}
