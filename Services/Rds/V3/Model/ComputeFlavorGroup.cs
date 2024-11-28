using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 查询数据库可变更规格接口中，规格组类型
    /// </summary>
    public class ComputeFlavorGroup 
    {

        /// <summary>
        /// 性能规格，包含以下状态：  normal：通用增强型。 normal2：通用增强Ⅱ型。 armFlavors：鲲鹏通用增强型。 dedicicateNormal（dedicatedNormalLocalssd）：x86独享型。 armLocalssd：鲲鹏通用型。 normalLocalssd：x86通用型。 general：通用型。 dedicated 对于PostgreSQL引擎：独享型
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 计算规格列表
        /// </summary>
        [JsonProperty("compute_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeFlavor> ComputeFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeFlavorGroup {\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  computeFlavors: ").Append(ComputeFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComputeFlavorGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComputeFlavorGroup input)
        {
            if (input == null) return false;
            if (this.GroupType != input.GroupType || (this.GroupType != null && !this.GroupType.Equals(input.GroupType))) return false;
            if (this.ComputeFlavors != input.ComputeFlavors || (this.ComputeFlavors != null && input.ComputeFlavors != null && !this.ComputeFlavors.SequenceEqual(input.ComputeFlavors))) return false;

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
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.ComputeFlavors != null) hashCode = hashCode * 59 + this.ComputeFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
