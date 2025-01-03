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
    public class CreateProjectModuleRequestBody 
    {

        /// <summary>
        /// 模块描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 父模块id
        /// </summary>
        [JsonProperty("parent_module_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserRequest Owner { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProjectModuleRequestBody {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  parentModuleId: ").Append(ParentModuleId).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProjectModuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProjectModuleRequestBody input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.ParentModuleId != input.ParentModuleId || (this.ParentModuleId != null && !this.ParentModuleId.Equals(input.ParentModuleId))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.ParentModuleId != null) hashCode = hashCode * 59 + this.ParentModuleId.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                return hashCode;
            }
        }
    }
}
