using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectChildModule 
    {

        /// <summary>
        /// 模块id
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public ModuleOwner Owner { get; set; }

        /// <summary>
        /// 模块层级
        /// </summary>
        [JsonProperty("deepth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deepth { get; set; }

        /// <summary>
        /// 是否是父级，true 父模块， false 非父模块
        /// </summary>
        [JsonProperty("is_parent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsParent { get; set; }

        /// <summary>
        /// 父模块id
        /// </summary>
        [JsonProperty("parent_module_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentModuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectChildModule {\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  deepth: ").Append(Deepth).Append("\n");
            sb.Append("  isParent: ").Append(IsParent).Append("\n");
            sb.Append("  parentModuleId: ").Append(ParentModuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectChildModule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectChildModule input)
        {
            if (input == null) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Deepth != input.Deepth || (this.Deepth != null && !this.Deepth.Equals(input.Deepth))) return false;
            if (this.IsParent != input.IsParent || (this.IsParent != null && !this.IsParent.Equals(input.IsParent))) return false;
            if (this.ParentModuleId != input.ParentModuleId || (this.ParentModuleId != null && !this.ParentModuleId.Equals(input.ParentModuleId))) return false;

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
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Deepth != null) hashCode = hashCode * 59 + this.Deepth.GetHashCode();
                if (this.IsParent != null) hashCode = hashCode * 59 + this.IsParent.GetHashCode();
                if (this.ParentModuleId != null) hashCode = hashCode * 59 + this.ParentModuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
