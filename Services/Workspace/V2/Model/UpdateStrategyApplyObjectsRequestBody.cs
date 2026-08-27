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
    /// 批量操作策略应用对象请求
    /// </summary>
    public class UpdateStrategyApplyObjectsRequestBody 
    {

        /// <summary>
        /// 操作类型：1-批量删除 2-批量新增
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OperateType { get; set; }

        /// <summary>
        /// 批量删除的应用对象ID列表（operate_type为1时必填）
        /// </summary>
        [JsonProperty("delete_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeleteIds { get; set; }

        /// <summary>
        /// 批量新增的应用对象列表（operate_type为2时必填）
        /// </summary>
        [JsonProperty("add_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplyObjectInfo> AddObjects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateStrategyApplyObjectsRequestBody {\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  deleteIds: ").Append(DeleteIds).Append("\n");
            sb.Append("  addObjects: ").Append(AddObjects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateStrategyApplyObjectsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateStrategyApplyObjectsRequestBody input)
        {
            if (input == null) return false;
            if (this.OperateType != input.OperateType || (this.OperateType != null && !this.OperateType.Equals(input.OperateType))) return false;
            if (this.DeleteIds != input.DeleteIds || (this.DeleteIds != null && input.DeleteIds != null && !this.DeleteIds.SequenceEqual(input.DeleteIds))) return false;
            if (this.AddObjects != input.AddObjects || (this.AddObjects != null && input.AddObjects != null && !this.AddObjects.SequenceEqual(input.AddObjects))) return false;

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
                if (this.OperateType != null) hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.DeleteIds != null) hashCode = hashCode * 59 + this.DeleteIds.GetHashCode();
                if (this.AddObjects != null) hashCode = hashCode * 59 + this.AddObjects.GetHashCode();
                return hashCode;
            }
        }
    }
}
